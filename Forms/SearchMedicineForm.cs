
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AlAmanPharmacyUI.Forms
{
    public partial class SearchMedicineForm : AlAmanPharmacyUI.Controls.ChromeForm
    {
        public SearchMedicineForm()
        {
            InitializeComponent();

            this.Load += SearchMedicineForm_Load;
            btnSearch.Click += btnSearch_Click;
        }

        // 1- تحميل الأصناف
        private void SearchMedicineForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // 2- جلب الأصناف من قاعدة البيانات
        private void LoadCategories()
        {
            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    string sql = @"
                        SELECT CategoryID, CategoryName
                        FROM Categories
                        ORDER BY CategoryName";

                    using (OracleCommand cmd = new OracleCommand(sql, con))
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DataRow row = dt.NewRow();
                        row["CategoryID"] = DBNull.Value;
                        row["CategoryName"] = "كل الأصناف";

                        dt.Rows.InsertAt(row, 0);

                        cmbCategory.DataSource = dt;
                        cmbCategory.DisplayMember = "CategoryName";
                        cmbCategory.ValueMember = "CategoryID";
                        cmbCategory.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل الأصناف: " + ex.Message);
            }
        }

        // 3- تحديد اليوم الحالي
        private string GetTodayName()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday: return "Saturday";
                case DayOfWeek.Sunday: return "Sunday";
                case DayOfWeek.Monday: return "Monday";
                case DayOfWeek.Tuesday: return "Tuesday";
                case DayOfWeek.Wednesday: return "Wednesday";
                case DayOfWeek.Thursday: return "Thursday";
                case DayOfWeek.Friday: return "Friday";
                default: return "";
            }
        }

        // 4- البحث عن الأدوية والصيدليات
        private DataTable SearchMedicine()
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT
                    m.MedicineName,
                    m.Strength,
                    m.DosageForm,
                    c.CategoryName,
                    p.PharmacyName,
                    p.Address,
                    p.Phone,
                    pm.Price,
                    pm.Quantity,

                    pm.LastUpdate,

                    TO_CHAR(wh.OpenTime, 'HH24:MI') AS OpenTime,
                    TO_CHAR(wh.CloseTime, 'HH24:MI') AS CloseTime,

                    wh.IsOpen

                FROM Medicines m

                JOIN Categories c
                    ON m.CategoryID = c.CategoryID

                JOIN PharmacyMedicines pm
                    ON m.MedicineID = pm.MedicineID

                JOIN Pharmacies p
                    ON pm.PharmaciesID = p.PharmaciesID

                LEFT JOIN WorkingHours wh
                    ON p.PharmaciesID = wh.PharmaciesID
                    AND wh.DayOfWeek = :dayName

                WHERE
                    (:medicineName IS NULL
                     OR LOWER(m.MedicineName) LIKE LOWER(:medicineName))

                    AND

                    (:categoryID IS NULL
                     OR m.CategoryID = :categoryID)

                ORDER BY p.PharmacyName";

            using (OracleConnection con = Database.GetConnection())
            {
                con.Open();

                using (OracleCommand cmd = new OracleCommand(sql, con))
                {
                    cmd.BindByName = true;

                    cmd.Parameters.Add("dayName", OracleDbType.Varchar2)
                        .Value = GetTodayName();

                    string medicineName = txtMedName.Text.Trim();

                    cmd.Parameters.Add("medicineName", OracleDbType.Varchar2)
                        .Value = string.IsNullOrWhiteSpace(medicineName)
                        ? (object)DBNull.Value
                        : "%" + medicineName + "%";

                    object categoryID = cmbCategory.SelectedValue;

                    if (categoryID == null || categoryID == DBNull.Value)
                    {
                        categoryID = DBNull.Value;
                    }

                    cmd.Parameters.Add("categoryID", OracleDbType.Int32)
                        .Value = categoryID;

                    using (OracleDataAdapter adapter =
                        new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // 5- معرفة حالة الصيدلية
        private string GetPharmacyStatus(DataRow row)
        {
            if (row["IsOpen"] == DBNull.Value)
                return "لا يوجد دوام اليوم";

            int isOpen = Convert.ToInt32(row["IsOpen"]);

            if (isOpen == 0)
                return "مغلقة اليوم";

            if (row["OpenTime"] == DBNull.Value ||
                row["CloseTime"] == DBNull.Value)
                return "وقت غير محدد";

            TimeSpan openTime;
            TimeSpan closeTime;

            if (!TimeSpan.TryParse(row["OpenTime"].ToString(), out openTime) ||
                !TimeSpan.TryParse(row["CloseTime"].ToString(), out closeTime))
            {
                return "وقت غير صالح";
            }

            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            bool isOpenNow;

            if (openTime <= closeTime)
            {
                isOpenNow =
                    currentTime >= openTime &&
                    currentTime <= closeTime;
            }
            else
            {
                isOpenNow =
                    currentTime >= openTime ||
                    currentTime <= closeTime;
            }

            return isOpenNow ? "مفتوحة الآن" : "مغلقة الآن";
        }

        // 6- إضافة حالة الصيدلية
        private void AddPharmacyStatus(DataTable dt)
        {
            dt.Columns.Add("PharmacyStatus", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                row["PharmacyStatus"] = GetPharmacyStatus(row);
            }
        }

        // 7- عرض النتائج
        private void DisplayResults(DataTable dt)
        {
            dgvResults.AutoGenerateColumns = false;

            colName.DataPropertyName = "MedicineName";

            colStrength.DataPropertyName = "Strength";
            colDosageForm.DataPropertyName = "DosageForm";

            colPharmacy.DataPropertyName = "PharmacyName";
            colPrice.DataPropertyName = "Price";
            colAddress.DataPropertyName = "Address";
            colPhone.DataPropertyName = "Phone";
            colQuantity.DataPropertyName = "Quantity";
            Column2.DataPropertyName = "OpenTime";
            Column3.DataPropertyName = "CloseTime";
            Column4.DataPropertyName = "PharmacyStatus";

            // آخر تحديث
            LastUpdate.DataPropertyName = "LastUpdate";
            LastUpdate.HeaderText = "آخر تحديث";
            LastUpdate.DefaultCellStyle.Format = "yyyy/MM/dd hh:mm tt";

            colName.HeaderText = "اسم الدواء";
            colStrength.HeaderText = "التركيز";
            colDosageForm.HeaderText = "الشكل الدوائي";

            colPharmacy.HeaderText = "الصيدلية";
            colPrice.HeaderText = "السعر";
            colAddress.HeaderText = "العنوان";
            colPhone.HeaderText = "رقم الهاتف";
            colQuantity.HeaderText = " الكمية";

            Column2.HeaderText = "وقت الفتح";
            Column3.HeaderText = "وقت الإغلاق";
            Column4.HeaderText = "حالة الصيدلية";

            dgvResults.DataSource = dt;
        }

        // 8- تنفيذ البحث
        private void LoadSearchResults()
        {
            if (string.IsNullOrWhiteSpace(txtMedName.Text) &&
                (cmbCategory.SelectedValue == null ||
                 cmbCategory.SelectedValue == DBNull.Value))
            {
                MessageBox.Show("اكتب اسم الدواء أو اختر الصنف");
                return;
            }

            try
            {
                DataTable dt = SearchMedicine();

                AddPharmacyStatus(dt);

                DisplayResults(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على نتائج");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        // 9- زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearchResults();
        }

        private void dgvResults_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvResults_CellContentClick_1(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
