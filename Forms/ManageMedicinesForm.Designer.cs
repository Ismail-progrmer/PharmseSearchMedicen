namespace AlAmanPharmacyUI.Forms
{
    partial class ManageMedicinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMedicinesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            btnAdd = new AlAmanPharmacyUI.Controls.RoundedButton();
            btnEdit = new AlAmanPharmacyUI.Controls.RoundedButton();
            btnDelete = new AlAmanPharmacyUI.Controls.RoundedButton();
            dgvMedicines = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtQuantity = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            lblCategory = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtMedicineID = new System.Windows.Forms.TextBox();
            txtMedicineName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtStrength = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtDosageForm = new System.Windows.Forms.TextBox();
            MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DosageForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Image = (System.Drawing.Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new System.Drawing.Point(855, 332);
            btnAdd.Margin = new System.Windows.Forms.Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(314, 58);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "إضافة";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Image = (System.Drawing.Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new System.Drawing.Point(422, 332);
            btnEdit.Margin = new System.Windows.Forms.Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(312, 58);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "تعديل";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Image = (System.Drawing.Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new System.Drawing.Point(70, 328);
            btnDelete.Margin = new System.Windows.Forms.Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(268, 62);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.AllowUserToDeleteRows = false;
            dgvMedicines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicines.BackgroundColor = System.Drawing.Color.White;
            dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(44, 98, 174);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicines.ColumnHeadersHeight = 44;
            dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { MedicineID, MedicineName, CategoryName, Price, Quantity, Strength, DosageForm });
            dgvMedicines.EnableHeadersVisualStyles = false;
            dgvMedicines.GridColor = System.Drawing.Color.FromArgb(214, 224, 239);
            dgvMedicines.Location = new System.Drawing.Point(46, 420);
            dgvMedicines.Margin = new System.Windows.Forms.Padding(4);
            dgvMedicines.MultiSelect = false;
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersVisible = false;
            dgvMedicines.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(189, 215, 242);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            dgvMedicines.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvMedicines.RowTemplate.Height = 38;
            dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new System.Drawing.Size(1274, 606);
            dgvMedicines.TabIndex = 5;
            dgvMedicines.CellClick += dgvMedicines_CellClick;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label2.Location = new System.Drawing.Point(1142, 178);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(173, 39);
            label2.TabIndex = 8;
            label2.Text = "السعر";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(680, 186);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(403, 26);
            txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label3.Location = new System.Drawing.Point(447, 134);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(173, 39);
            label3.TabIndex = 10;
            label3.Text = "الكمية";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(23, 147);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(379, 26);
            txtQuantity.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label1.Location = new System.Drawing.Point(436, 61);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 39);
            label1.TabIndex = 6;
            label1.Text = "اسم الدواء";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(680, 129);
            cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(403, 26);
            cmbCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCategory.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblCategory.Location = new System.Drawing.Point(1142, 121);
            lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(173, 39);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "التصنيف:";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label4.Location = new System.Drawing.Point(1125, 61);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 39);
            label4.TabIndex = 13;
            label4.Text = "رقم الدواء";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMedicineID
            // 
            txtMedicineID.Location = new System.Drawing.Point(680, 69);
            txtMedicineID.Name = "txtMedicineID";
            txtMedicineID.Size = new System.Drawing.Size(403, 26);
            txtMedicineID.TabIndex = 12;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new System.Drawing.Point(23, 69);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new System.Drawing.Size(379, 26);
            txtMedicineName.TabIndex = 7;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label5.Location = new System.Drawing.Point(436, 195);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 39);
            label5.TabIndex = 14;
            label5.Text = "قوة الدواء";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStrength
            // 
            txtStrength.Location = new System.Drawing.Point(23, 203);
            txtStrength.Name = "txtStrength";
            txtStrength.Size = new System.Drawing.Size(379, 26);
            txtStrength.TabIndex = 15;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            label6.Location = new System.Drawing.Point(1142, 241);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(173, 39);
            label6.TabIndex = 16;
            label6.Text = "شكل الدواء";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDosageForm
            // 
            txtDosageForm.Location = new System.Drawing.Point(680, 249);
            txtDosageForm.Name = "txtDosageForm";
            txtDosageForm.Size = new System.Drawing.Size(403, 26);
            txtDosageForm.TabIndex = 17;
            // 
            // MedicineID
            // 
            MedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            MedicineID.HeaderText = "رقم الدواء";
            MedicineID.MinimumWidth = 6;
            MedicineID.Name = "MedicineID";
            MedicineID.ReadOnly = true;
            MedicineID.Width = 190;
            // 
            // MedicineName
            // 
            MedicineName.FillWeight = 35F;
            MedicineName.HeaderText = "اسم الدواء";
            MedicineName.MinimumWidth = 140;
            MedicineName.Name = "MedicineName";
            MedicineName.ReadOnly = true;
            MedicineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CategoryName
            // 
            CategoryName.FillWeight = 26F;
            CategoryName.HeaderText = "التصنيف";
            CategoryName.MinimumWidth = 110;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            Price.FillWeight = 19F;
            Price.HeaderText = "السعر";
            Price.MinimumWidth = 90;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 20F;
            Quantity.HeaderText = "الكمية";
            Quantity.MinimumWidth = 90;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Strength
            // 
            Strength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Strength.HeaderText = "تركيز الدواء";
            Strength.MinimumWidth = 6;
            Strength.Name = "Strength";
            Strength.ReadOnly = true;
            Strength.Width = 200;
            // 
            // DosageForm
            // 
            DosageForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            DosageForm.HeaderText = "شكل الدواء";
            DosageForm.MinimumWidth = 6;
            DosageForm.Name = "DosageForm";
            DosageForm.ReadOnly = true;
            DosageForm.Width = 200;
            // 
            // ManageMedicinesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1390, 803);
            Controls.Add(txtDosageForm);
            Controls.Add(label6);
            Controls.Add(txtStrength);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMedicineID);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtMedicineName);
            Controls.Add(label1);
            Controls.Add(dgvMedicines);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(427, 305);
            Name = "ManageMedicinesForm";
            Text = "إدارة الأدوية";
            Load += ManageMedicinesForm_Load;
            Controls.SetChildIndex(lblCategory, 0);
            Controls.SetChildIndex(cmbCategory, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnEdit, 0);
            Controls.SetChildIndex(btnDelete, 0);
            Controls.SetChildIndex(dgvMedicines, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtMedicineName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtQuantity, 0);
            Controls.SetChildIndex(txtMedicineID, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtStrength, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtDosageForm, 0);
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AlAmanPharmacyUI.Controls.RoundedButton btnAdd;
        private AlAmanPharmacyUI.Controls.RoundedButton btnEdit;
        private AlAmanPharmacyUI.Controls.RoundedButton btnDelete;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDosageForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosageForm;
    }
}
