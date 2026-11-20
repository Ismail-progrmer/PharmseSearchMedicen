
using Oracle.ManagedDataAccess.Client;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Forms
{
    public partial class ManagePharmacyForm : AlAmanPharmacyUI.Controls.ChromeForm
    {
        public int PharmacyID;

        public ManagePharmacyForm(int PharmacyID)
        {
            InitializeComponent();
            this.PharmacyID = PharmacyID;
        }

        // تحويل الوقت العربي إلى TimeSpan
        private bool TryConvertTime(string time, out TimeSpan result)
        {
            result = TimeSpan.Zero;

            if (string.IsNullOrWhiteSpace(time))
                return false;

            time = time.Trim()
                .Replace("ص", "AM")
                .Replace("م", "PM");

            // إذا كان الوقت بصيغة 24 ساعة
            if (TimeSpan.TryParse(time, out result))
            {
                return result >= TimeSpan.Zero &&
                       result < TimeSpan.FromDays(1);
            }

            // إذا كان الوقت بصيغة صباحاً أو مساءً
            string[] formats =
            {
                "h:mm tt",
                "hh:mm tt"
            };

            if (DateTime.TryParseExact(
                time,
                formats,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsed))
            {
                result = parsed.TimeOfDay;
                return true;
            }

            return false;
        }

        // تحويل الوقت إلى العرض العربي
        private string ConvertTimeForDisplay(string time)
        {
            if (TryConvertTime(time, out TimeSpan result))
            {
                string formatted = DateTime.Today.Add(result)
                    .ToString("h:mm tt", CultureInfo.InvariantCulture);

                return formatted.Replace("AM", "ص")
                                .Replace("PM", "م");
            }

            return time;
        }

        // تحميل بيانات الصيدلية وساعات العمل
        private void LoadPharmacyInfo()
        {
            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    // تحميل بيانات الصيدلية
                    string pharmacyQuery = @"
                        SELECT PharmacyName, Address, Phone
                        FROM Pharmacies
                        WHERE PharmaciesID = :id";

                    using (OracleCommand cmd =
                        new OracleCommand(pharmacyQuery, con))
                    {
                        cmd.BindByName = true;

                        cmd.Parameters.Add(
                            "id", OracleDbType.Int32).Value = PharmacyID;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtPharmacyName.Text =
                                    reader["PharmacyName"].ToString();

                                txtAddress.Text =
                                    reader["Address"].ToString();

                                txtPhone.Text =
                                    reader["Phone"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "لم يتم العثور على بيانات الصيدلية");
                                return;
                            }
                        }
                    }

                    // تحميل ساعات العمل
                    string hoursQuery = @"
                        SELECT DayOfWeek, OpenTime, CloseTime, IsOpen
                        FROM WorkingHours
                        WHERE PharmaciesID = :id";

                    using (OracleCommand cmd =
                        new OracleCommand(hoursQuery, con))
                    {
                        cmd.BindByName = true;

                        cmd.Parameters.Add(
                            "id", OracleDbType.Int32).Value = PharmacyID;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // جعل جميع الأيام مغلقة افتراضياً
                            chkSaturday.Checked = false;
                            chkSunday.Checked = false;
                            chkMonday.Checked = false;
                            chkTuesday.Checked = false;
                            chkWednesday.Checked = false;
                            chkThursday.Checked = false;
                            chkFriday.Checked = false;

                            while (reader.Read())
                            {
                                string day =
                                    reader["DayOfWeek"].ToString();

                                bool isOpen =
                                    Convert.ToInt32(reader["IsOpen"]) == 1;

                                string openTime = "";
                                string closeTime = "";

                                // قراءة الوقت من Oracle DATE
                                if (reader["OpenTime"] != DBNull.Value)
                                {
                                    openTime = Convert.ToDateTime(
                                        reader["OpenTime"])
                                        .ToString("HH:mm");
                                }

                                if (reader["CloseTime"] != DBNull.Value)
                                {
                                    closeTime = Convert.ToDateTime(
                                        reader["CloseTime"])
                                        .ToString("HH:mm");
                                }

                                SetDayControls(
                                    day, isOpen, openTime, closeTime);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطأ تحميل بيانات الصيدلية: " + ex.Message);
            }
        }

        // تحديد عناصر التحكم الخاصة بكل يوم
        private void SetDayControls(
            string day,
            bool isOpen,
            string openTime,
            string closeTime)
        {
            CheckBox chk = null;
            ComboBox open = null;
            ComboBox close = null;

            switch (day)
            {
                case "Saturday":
                case "السبت":
                    chk = chkSaturday;
                    open = cmbSaturdayOpen;
                    close = cmbSaturdayClose;
                    break;

                case "Sunday":
                case "الأحد":
                    chk = chkSunday;
                    open = cmbSundayOpen;
                    close = cmbSundayClose;
                    break;

                case "Monday":
                case "الاثنين":
                case "الإثنين":
                    chk = chkMonday;
                    open = cmbMondayOpen;
                    close = cmbMondayClose;
                    break;

                case "Tuesday":
                case "الثلاثاء":
                    chk = chkTuesday;
                    open = cmbTuesdayOpen;
                    close = cmbTuesdayClose;
                    break;

                case "Wednesday":
                case "الأربعاء":
                    chk = chkWednesday;
                    open = cmbWednesdayOpen;
                    close = cmbWednesdayClose;
                    break;

                case "Thursday":
                case "الخميس":
                    chk = chkThursday;
                    open = cmbThursdayOpen;
                    close = cmbThursdayClose;
                    break;

                case "Friday":
                case "الجمعة":
                    chk = chkFriday;
                    open = cmbFridayOpen;
                    close = cmbFridayClose;
                    break;
            }

            if (chk == null)
                return;

            chk.Checked = isOpen;

            open.Enabled = isOpen;
            close.Enabled = isOpen;

            open.Text = isOpen
                ? ConvertTimeForDisplay(openTime)
                : "";

            close.Text = isOpen
                ? ConvertTimeForDisplay(closeTime)
                : "";
        }

        // حفظ بيانات الصيدلية وساعات العمل
        private void SavePharmacyInfo()
        {
            // التحقق من بيانات الصيدلية
            if (string.IsNullOrWhiteSpace(txtPharmacyName.Text))
            {
                MessageBox.Show("اسم الصيدلية لا يمكن أن يكون فارغاً");
                txtPharmacyName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("العنوان لا يمكن أن يكون فارغاً");
                txtAddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("رقم الهاتف لا يمكن أن يكون فارغاً");
                txtPhone.Focus();
                return;
            }

            // تجميع أيام الأسبوع
            var days = new[]
            {
                (Day: "Saturday", Check: chkSaturday,
                 Open: cmbSaturdayOpen, Close: cmbSaturdayClose),

                (Day: "Sunday", Check: chkSunday,
                 Open: cmbSundayOpen, Close: cmbSundayClose),

                (Day: "Monday", Check: chkMonday,
                 Open: cmbMondayOpen, Close: cmbMondayClose),

                (Day: "Tuesday", Check: chkTuesday,
                 Open: cmbTuesdayOpen, Close: cmbTuesdayClose),

                (Day: "Wednesday", Check: chkWednesday,
                 Open: cmbWednesdayOpen, Close: cmbWednesdayClose),

                (Day: "Thursday", Check: chkThursday,
                 Open: cmbThursdayOpen, Close: cmbThursdayClose),

                (Day: "Friday", Check: chkFriday,
                 Open: cmbFridayOpen, Close: cmbFridayClose)
            };

            // التحقق من أوقات الأيام المفتوحة
            foreach (var day in days)
            {
                if (day.Check.Checked)
                {
                    TimeSpan start, end;

                    if (!TryConvertTime(day.Open.Text, out start) ||
                        !TryConvertTime(day.Close.Text, out end))
                    {
                        MessageBox.Show(
                            "يرجى اختيار أوقات صحيحة ليوم " + day.Day);
                        return;
                    }

                    if (start >= end)
                    {
                        MessageBox.Show(
                            "وقت الإغلاق يجب أن يكون بعد وقت الفتح ليوم "
                            + day.Day);
                        return;
                    }
                }
            }

            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    using (OracleTransaction transaction =
                        con.BeginTransaction())
                    {
                        try
                        {
                            // تحديث بيانات الصيدلية
                            string pharmacySql = @"
                                UPDATE Pharmacies
                                SET PharmacyName = :name,
                                    Address = :address,
                                    Phone = :phone
                                WHERE PharmaciesID = :id";

                            using (OracleCommand cmd =
                                new OracleCommand(pharmacySql, con))
                            {
                                cmd.Transaction = transaction;
                                cmd.BindByName = true;

                                cmd.Parameters.Add(
                                    "name", OracleDbType.Varchar2)
                                    .Value = txtPharmacyName.Text.Trim();

                                cmd.Parameters.Add(
                                    "address", OracleDbType.Varchar2)
                                    .Value = txtAddress.Text.Trim();

                                cmd.Parameters.Add(
                                    "phone", OracleDbType.Varchar2)
                                    .Value = txtPhone.Text.Trim();

                                cmd.Parameters.Add(
                                    "id", OracleDbType.Int32)
                                    .Value = PharmacyID;

                                if (cmd.ExecuteNonQuery() == 0)
                                    throw new Exception(
                                        "لم يتم العثور على الصيدلية");
                            }

                            // حفظ أيام الأسبوع السبعة
                            foreach (var day in days)
                            {
                                int isOpen =
                                    day.Check.Checked ? 1 : 0;

                                object openTime = DBNull.Value;
                                object closeTime = DBNull.Value;

                                // تحويل الوقت إلى DateTime
                                // لأن الأعمدة في Oracle من نوع DATE
                                if (isOpen == 1)
                                {
                                    TryConvertTime(
                                        day.Open.Text, out TimeSpan start);

                                    TryConvertTime(
                                        day.Close.Text, out TimeSpan end);

                                    openTime = DateTime.Today.Add(start);
                                    closeTime = DateTime.Today.Add(end);
                                }

                                // تحديث اليوم إذا كان موجوداً
                                string updateSql = @"
                                    UPDATE WorkingHours
                                    SET OpenTime = :openTime,
                                        CloseTime = :closeTime,
                                        IsOpen = :isOpen
                                    WHERE PharmaciesID = :id
                                    AND DayOfWeek = :day";

                                int result;

                                using (OracleCommand cmd =
                                    new OracleCommand(updateSql, con))
                                {
                                    cmd.Transaction = transaction;
                                    cmd.BindByName = true;

                                    cmd.Parameters.Add(
                                        "openTime", OracleDbType.Date)
                                        .Value = openTime;

                                    cmd.Parameters.Add(
                                        "closeTime", OracleDbType.Date)
                                        .Value = closeTime;

                                    cmd.Parameters.Add(
                                        "isOpen", OracleDbType.Int32)
                                        .Value = isOpen;

                                    cmd.Parameters.Add(
                                        "id", OracleDbType.Int32)
                                        .Value = PharmacyID;

                                    cmd.Parameters.Add(
                                        "day", OracleDbType.Varchar2)
                                        .Value = day.Day;

                                    result = cmd.ExecuteNonQuery();
                                }

                                // إضافة اليوم إذا لم يكن موجوداً
                                if (result == 0)
                                {
                                    string insertSql = @"
                                        INSERT INTO WorkingHours
                                        (
                                            WorkingHoursID,
                                            PharmaciesID,
                                            DayOfWeek,
                                            OpenTime,
                                            CloseTime,
                                            IsOpen
                                        )
                                        VALUES
                                        (
                                            (SELECT NVL(MAX(WorkingHoursID), 0) + 1
                                             FROM WorkingHours),
                                            :id,
                                            :day,
                                            :openTime,
                                            :closeTime,
                                            :isOpen
                                        )";

                                    using (OracleCommand cmd =
                                        new OracleCommand(insertSql, con))
                                    {
                                        cmd.Transaction = transaction;
                                        cmd.BindByName = true;

                                        cmd.Parameters.Add(
                                            "id", OracleDbType.Int32)
                                            .Value = PharmacyID;

                                        cmd.Parameters.Add(
                                            "day", OracleDbType.Varchar2)
                                            .Value = day.Day;

                                        cmd.Parameters.Add(
                                            "openTime", OracleDbType.Date)
                                            .Value = openTime;

                                        cmd.Parameters.Add(
                                            "closeTime", OracleDbType.Date)
                                            .Value = closeTime;

                                        cmd.Parameters.Add(
                                            "isOpen", OracleDbType.Int32)
                                            .Value = isOpen;

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // تأكيد الحفظ مرة واحدة بعد الأيام السبعة
                            transaction.Commit();
                        }
                        catch
                        {
                            try
                            {
                                transaction.Rollback();
                            }
                            catch
                            {
                                // تجاهل خطأ التراجع
                            }

                            throw;
                        }
                    }
                }

                // رسالة النجاح بعد إغلاق الاتصال
                MessageBox.Show(
                    "تم حفظ بيانات الصيدلية وساعات العمل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "حدث خطأ أثناء الحفظ: " + ex.Message);
            }
        }

        // تحديث حالة القوائم حسب اختيار اليوم
        private void UpdateDayControls(
            CheckBox checkBox,
            ComboBox openCombo,
            ComboBox closeCombo)
        {
            openCombo.Enabled = checkBox.Checked;
            closeCombo.Enabled = checkBox.Checked;

            if (!checkBox.Checked)
            {
                openCombo.SelectedIndex = -1;
                closeCombo.SelectedIndex = -1;

                openCombo.Text = "";
                closeCombo.Text = "";
            }
        }

        // أحداث اختيار أيام العمل
        private void chkSaturday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkSaturday, cmbSaturdayOpen, cmbSaturdayClose);
        }

        private void chkSunday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkSunday, cmbSundayOpen, cmbSundayClose);
        }

        private void chkMonday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkMonday, cmbMondayOpen, cmbMondayClose);
        }

        private void chkTuesday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkTuesday, cmbTuesdayOpen, cmbTuesdayClose);
        }

        private void chkWednesday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkWednesday, cmbWednesdayOpen, cmbWednesdayClose);
        }

        private void chkThursday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkThursday, cmbThursdayOpen, cmbThursdayClose);
        }

        private void chkFriday_CheckedChanged(
            object sender, EventArgs e)
        {
            UpdateDayControls(
                chkFriday, cmbFridayOpen, cmbFridayClose);
        }

        // زر حفظ التغييرات
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SavePharmacyInfo();
        }

        // عند فتح الواجهة
        private void ManagePharmacyForm_Load(
            object sender, EventArgs e)
        {
            LoadPharmacyInfo();
        }

        private void cmbSaturdayOpen_SelectedIndexChanged(
            object sender, EventArgs e)
        {

        }
    }
}
