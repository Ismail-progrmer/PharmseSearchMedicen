
using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace AlAmanPharmacyUI.Forms
{
    public partial class ManageMedicinesForm :
        AlAmanPharmacyUI.Controls.ChromeForm
    {
        public int PharmacyID;
        private int SelectedMedicineID = -1;

        public ManageMedicinesForm(int PharmacyID)
        {
            InitializeComponent();
            this.PharmacyID = PharmacyID;
        }

        // تحميل التصنيفات
        private void LoadCategories()
        {
            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT CategoryID, CategoryName
                        FROM Categories
                        ORDER BY CategoryName";

                    OracleDataAdapter adapter =
                        new OracleDataAdapter(query, con);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCategory.DataSource = dt;
                    cmbCategory.DisplayMember = "CategoryName";
                    cmbCategory.ValueMember = "CategoryID";

                    cmbCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تحميل التصنيفات: " + ex.Message);
            }
        }

        // التحقق من المدخلات
        private bool ValidateFields()
        {
            if (!int.TryParse(txtMedicineID.Text, out int medicineID)
                || medicineID <= 0)
            {
                MessageBox.Show("يرجى إدخال رقم دواء صحيح");
                txtMedicineID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الدواء");
                txtMedicineName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStrength.Text))
            {
                MessageBox.Show("يرجى إدخال تركيز الدواء");
                txtStrength.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDosageForm.Text))
            {
                MessageBox.Show("يرجى إدخال شكل الدواء");
                txtDosageForm.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price)
                || price <= 0)
            {
                MessageBox.Show("السعر يجب أن يكون أكبر من صفر");
                txtPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity)
                || quantity <= 0)
            {
                MessageBox.Show("الكمية يجب أن تكون أكبر من صفر");
                txtQuantity.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex == -1 ||
                cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار التصنيف");
                cmbCategory.Focus();
                return false;
            }

            return true;
        }

        // تحميل الأدوية الخاصة بالصيدلية
        private void LoadMedicines()
        {
            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT
                            M.MedicineID,
                            M.MedicineName,
                            C.CategoryName,
                            M.CategoryID,
                            M.Strength,
                            M.DosageForm,
                            PM.Price,
                            PM.Quantity
                        FROM Medicines M
                        INNER JOIN Categories C
                            ON M.CategoryID = C.CategoryID
                        INNER JOIN PharmacyMedicines PM
                            ON M.MedicineID = PM.MedicineID
                        WHERE PM.PharmaciesID = :pharmacyID
                        ORDER BY M.MedicineName";

                    using (OracleDataAdapter adapter =
                        new OracleDataAdapter(query, con))
                    {
                        adapter.SelectCommand.BindByName = true;

                        adapter.SelectCommand.Parameters.Add(
                            "pharmacyID", OracleDbType.Int32).Value = PharmacyID;

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvMedicines.AutoGenerateColumns = false;

                        dgvMedicines.DataSource = dt;

                        dgvMedicines.Columns["MedicineID"].DataPropertyName = "MedicineID";
                        dgvMedicines.Columns["MedicineID"].HeaderText = "رقم الدواء";

                        dgvMedicines.Columns["MedicineName"].DataPropertyName = "MedicineName";
                        dgvMedicines.Columns["MedicineName"].HeaderText = "اسم الدواء";

                        dgvMedicines.Columns["CategoryName"].DataPropertyName = "CategoryName";
                        dgvMedicines.Columns["CategoryName"].HeaderText = "التصنيف";

                        dgvMedicines.Columns["Strength"].DataPropertyName = "Strength";
                        dgvMedicines.Columns["Strength"].HeaderText = "التركيز";

                        dgvMedicines.Columns["DosageForm"].DataPropertyName = "DosageForm";
                        dgvMedicines.Columns["DosageForm"].HeaderText = "شكل الدواء";

                        dgvMedicines.Columns["Price"].DataPropertyName = "Price";
                        dgvMedicines.Columns["Price"].HeaderText = "السعر";

                        dgvMedicines.Columns["Quantity"].DataPropertyName = "Quantity";
                        dgvMedicines.Columns["Quantity"].HeaderText = "الكمية";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تحميل الأدوية: " + ex.Message);
            }
        }

        // عند فتح الواجهة
        private void ManageMedicinesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMedicines();
        }

        // اختيار دواء من الجدول
        private void dgvMedicines_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvMedicines.Rows[e.RowIndex];

            SelectedMedicineID =
                Convert.ToInt32(row.Cells["MedicineID"].Value);

            txtMedicineID.Text = SelectedMedicineID.ToString();

            txtMedicineName.Text =
                row.Cells["MedicineName"].Value.ToString();

            txtStrength.Text =
                row.Cells["Strength"].Value.ToString();

            txtDosageForm.Text =
                row.Cells["DosageForm"].Value.ToString();

            txtPrice.Text =
                row.Cells["Price"].Value.ToString();

            txtQuantity.Text =
                row.Cells["Quantity"].Value.ToString();

            cmbCategory.Text =
                row.Cells["CategoryName"].Value.ToString();

            // منع تغيير بيانات الدواء الأساسية
            txtMedicineID.Enabled = false;
            txtMedicineName.Enabled = false;
            txtStrength.Enabled = false;
            txtDosageForm.Enabled = false;
            cmbCategory.Enabled = false;
        }

        // زر الإضافة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMedicine();
        }

        // إضافة دواء جديد أو ربط دواء موجود بالصيدلية
        private void AddMedicine()
        {
            if (!ValidateFields())
                return;

            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    int medicineID = int.Parse(txtMedicineID.Text);
                    decimal price = decimal.Parse(txtPrice.Text);
                    int quantity = int.Parse(txtQuantity.Text);

                    // البحث عن الدواء بواسطة الرقم
                    string query = @"
                        SELECT COUNT(*)
                        FROM Medicines
                        WHERE MedicineID = :id";

                    OracleCommand cmd = new OracleCommand(query, con);

                    cmd.Parameters.Add("id", medicineID);

                    int exists = Convert.ToInt32(cmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        // إضافة الدواء إلى الجدول العام
                        string insert = @"
                            INSERT INTO Medicines
                            (MedicineID, MedicineName, CategoryID,
                             Strength, DosageForm)
                            VALUES
                            (:id, :name, :category, :strength, :dosageForm)";

                        cmd = new OracleCommand(insert, con);
                        cmd.BindByName = true;

                        cmd.Parameters.Add("id", medicineID);

                        cmd.Parameters.Add(
                            "name", txtMedicineName.Text.Trim());

                        cmd.Parameters.Add(
                            "category", cmbCategory.SelectedValue);

                        cmd.Parameters.Add(
                            "strength", txtStrength.Text.Trim());

                        cmd.Parameters.Add(
                            "dosageForm", txtDosageForm.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // التأكد من تطابق بيانات الدواء الموجود
                        string checkMedicine = @"
                            SELECT COUNT(*)
                            FROM Medicines
                            WHERE MedicineID = :id
                            AND MedicineName = :name
                            AND CategoryID = :category
                            AND Strength = :strength
                            AND DosageForm = :dosageForm";

                        cmd = new OracleCommand(checkMedicine, con);
                        cmd.BindByName = true;

                        cmd.Parameters.Add("id", medicineID);

                        cmd.Parameters.Add(
                            "name", txtMedicineName.Text.Trim());

                        cmd.Parameters.Add(
                            "category", cmbCategory.SelectedValue);

                        cmd.Parameters.Add(
                            "strength", txtStrength.Text.Trim());

                        cmd.Parameters.Add(
                            "dosageForm", txtDosageForm.Text.Trim());

                        int sameMedicine =
                            Convert.ToInt32(cmd.ExecuteScalar());

                        if (sameMedicine == 0)
                        {
                            MessageBox.Show(
                                "رقم الدواء مستخدم لدواء آخر. تحقق من البيانات.");
                            return;
                        }
                    }

                    // التأكد من عدم تكرار الدواء في الصيدلية
                    string check = @"
                        SELECT COUNT(*)
                        FROM PharmacyMedicines
                        WHERE PharmaciesID = :pharmacy
                        AND MedicineID = :medicine";

                    cmd = new OracleCommand(check, con);

                    cmd.Parameters.Add("pharmacy", PharmacyID);
                    cmd.Parameters.Add("medicine", medicineID);

                    int linked =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    if (linked > 0)
                    {
                        MessageBox.Show(
                            "هذا الدواء مضاف مسبقاً إلى صيدليتك");
                        return;
                    }

                    // ربط الدواء بالصيدلية
                    string link = @"
                        INSERT INTO PharmacyMedicines
                        (PharmaciesID, MedicineID, Price,
                         Quantity, LastUpdate)
                        VALUES
                        (:pharmacy, :medicine, :price,
                         :quantity, SYSDATE)";

                    cmd = new OracleCommand(link, con);

                    cmd.Parameters.Add("pharmacy", PharmacyID);
                    cmd.Parameters.Add("medicine", medicineID);
                    cmd.Parameters.Add("price", price);
                    cmd.Parameters.Add("quantity", quantity);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("تمت إضافة الدواء بنجاح");

                ClearFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطأ أثناء إضافة الدواء: " + ex.Message);
            }
        }

        // زر التعديل
        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateMedicine();
        }

        // تعديل السعر والكمية
        private void UpdateMedicine()
        {
            if (SelectedMedicineID == -1)
            {
                MessageBox.Show("اختر دواء أولاً");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price)
                || price <= 0)
            {
                MessageBox.Show("السعر يجب أن يكون أكبر من صفر");
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity)
                || quantity <= 0)
            {
                MessageBox.Show("الكمية يجب أن تكون أكبر من صفر");
                txtQuantity.Focus();
                return;
            }

            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                        UPDATE PharmacyMedicines
                        SET Price = :price,
                            Quantity = :quantity,
                            LastUpdate = SYSDATE
                        WHERE PharmaciesID = :pharmacy
                        AND MedicineID = :medicine";

                    OracleCommand cmd = new OracleCommand(query, con);

                    cmd.Parameters.Add("price", price);
                    cmd.Parameters.Add("quantity", quantity);
                    cmd.Parameters.Add("pharmacy", PharmacyID);
                    cmd.Parameters.Add("medicine", SelectedMedicineID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("تم التعديل بنجاح");
                    else
                        MessageBox.Show("لم يتم العثور على الدواء");
                }

                ClearFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطأ أثناء التعديل: " + ex.Message);
            }
        }

        // زر الحذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMedicine();
        }

        // حذف الدواء من الصيدلية الحالية فقط
        private void DeleteMedicine()
        {
            if (SelectedMedicineID == -1)
            {
                MessageBox.Show("اختر دواء أولاً");
                return;
            }

            if (MessageBox.Show(
                "هل تريد حذف الدواء من صيدليتك؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                        DELETE FROM PharmacyMedicines
                        WHERE PharmaciesID = :pharmacy
                        AND MedicineID = :medicine";

                    OracleCommand cmd = new OracleCommand(query, con);

                    cmd.Parameters.Add("pharmacy", PharmacyID);
                    cmd.Parameters.Add("medicine", SelectedMedicineID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("تم الحذف بنجاح");
                    else
                        MessageBox.Show("لم يتم العثور على الدواء");
                }

                ClearFields();
                LoadMedicines();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "خطأ أثناء الحذف: " + ex.Message);
            }
        }

        // تفريغ الحقول
        private void ClearFields()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtStrength.Clear();
            txtDosageForm.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            cmbCategory.SelectedIndex = -1;

            txtMedicineID.Enabled = true;
            txtMedicineName.Enabled = true;
            txtStrength.Enabled = true;
            txtDosageForm.Enabled = true;
            cmbCategory.Enabled = true;

            SelectedMedicineID = -1;

            txtMedicineName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
