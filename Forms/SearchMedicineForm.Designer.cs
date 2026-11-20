namespace AlAmanPharmacyUI.Forms
{
    partial class SearchMedicineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMedicineForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            lblMedName = new System.Windows.Forms.Label();
            txtMedName = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            btnSearch = new AlAmanPharmacyUI.Controls.RoundedButton();
            dgvResults = new System.Windows.Forms.DataGridView();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPharmacy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDosageForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblMedName
            // 
            lblMedName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMedName.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblMedName.Location = new System.Drawing.Point(1656, 69);
            lblMedName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMedName.Name = "lblMedName";
            lblMedName.Size = new System.Drawing.Size(173, 39);
            lblMedName.TabIndex = 0;
            lblMedName.Text = "اسم الدواء:";
            lblMedName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMedName
            // 
            txtMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtMedName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMedName.Location = new System.Drawing.Point(1052, 69);
            txtMedName.Margin = new System.Windows.Forms.Padding(4);
            txtMedName.Name = "txtMedName";
            txtMedName.Size = new System.Drawing.Size(587, 27);
            txtMedName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblCategory.Location = new System.Drawing.Point(1684, 133);
            lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(173, 39);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "التصنيف:";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "-- اختر التصنيف --", "مسكنات", "مضادات حيوية", "فيتامينات ومكملات غذائية", "أدوية البرد والزكام", "أدوية الجهاز الهضمي", "مستحضرات تجميل وعناية" });
            cmbCategory.Location = new System.Drawing.Point(1052, 141);
            cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(603, 26);
            cmbCategory.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Image = (System.Drawing.Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new System.Drawing.Point(387, 77);
            btnSearch.Margin = new System.Windows.Forms.Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(429, 95);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = System.Drawing.Color.White;
            dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(44, 98, 174);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.ColumnHeadersHeight = 44;
            dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colName, colPharmacy, colPrice, colAddress, colPhone, colQuantity, colStrength, colDosageForm, LastUpdate, Column2, Column3, Column4 });
            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.GridColor = System.Drawing.Color.FromArgb(214, 224, 239);
            dgvResults.Location = new System.Drawing.Point(-21, 235);
            dgvResults.Margin = new System.Windows.Forms.Padding(4);
            dgvResults.MultiSelect = false;
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(189, 215, 242);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvResults.RowTemplate.Height = 38;
            dgvResults.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new System.Drawing.Size(1963, 498);
            dgvResults.TabIndex = 5;
            dgvResults.CellContentClick += dgvResults_CellContentClick_1;
            // 
            // colName
            // 
            colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colName.FillWeight = 25F;
            colName.HeaderText = "اسم الدواء";
            colName.MinimumWidth = 120;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colName.Width = 200;
            // 
            // colPharmacy
            // 
            colPharmacy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colPharmacy.FillWeight = 22F;
            colPharmacy.HeaderText = "الصيدلية";
            colPharmacy.MinimumWidth = 120;
            colPharmacy.Name = "colPharmacy";
            colPharmacy.ReadOnly = true;
            colPharmacy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colPharmacy.Width = 200;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colPrice.FillWeight = 13F;
            colPrice.HeaderText = "السعر";
            colPrice.MinimumWidth = 80;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colPrice.Width = 150;
            // 
            // colAddress
            // 
            colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colAddress.FillWeight = 25F;
            colAddress.HeaderText = "العنوان";
            colAddress.MinimumWidth = 120;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colAddress.Width = 180;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colPhone.FillWeight = 15F;
            colPhone.HeaderText = "رقم الهاتف";
            colPhone.MinimumWidth = 90;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colPhone.Width = 190;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colQuantity.HeaderText = "الكمية";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 140;
            // 
            // colStrength
            // 
            colStrength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colStrength.HeaderText = "التركيز";
            colStrength.MinimumWidth = 6;
            colStrength.Name = "colStrength";
            colStrength.ReadOnly = true;
            colStrength.Width = 120;
            // 
            // colDosageForm
            // 
            colDosageForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colDosageForm.HeaderText = "الشكل الدوائي";
            colDosageForm.MinimumWidth = 6;
            colDosageForm.Name = "colDosageForm";
            colDosageForm.ReadOnly = true;
            colDosageForm.Width = 140;
            // 
            // LastUpdate
            // 
            LastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            LastUpdate.HeaderText = "آخر تحديث";
            LastUpdate.MinimumWidth = 6;
            LastUpdate.Name = "LastUpdate";
            LastUpdate.ReadOnly = true;
            LastUpdate.Width = 220;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "وقت الفتح";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 160;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Column3.HeaderText = "وقت الاغلاق";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 160;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Column4.HeaderText = "حالة الصيدلية";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // SearchMedicineForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1942, 775);
            Controls.Add(dgvResults);
            Controls.Add(btnSearch);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtMedName);
            Controls.Add(lblMedName);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(427, 305);
            Name = "SearchMedicineForm";
            Text = "البحث عن الأدوية";
            Controls.SetChildIndex(lblMedName, 0);
            Controls.SetChildIndex(txtMedName, 0);
            Controls.SetChildIndex(lblCategory, 0);
            Controls.SetChildIndex(cmbCategory, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(dgvResults, 0);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private AlAmanPharmacyUI.Controls.RoundedButton btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPharmacy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosageForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
