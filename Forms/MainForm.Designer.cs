namespace AlAmanPharmacyUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            picLogo = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            btnPharmacy = new AlAmanPharmacyUI.Controls.RoundedButton();
            btnUser = new AlAmanPharmacyUI.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(363, 45);
            picLogo.Margin = new System.Windows.Forms.Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(293, 163);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblTitle.Location = new System.Drawing.Point(112, 231);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(800, 64);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "نضام ادارة الصيدليات الذكي";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(90, 107, 133);
            lblSubtitle.Location = new System.Drawing.Point(84, 310);
            lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(800, 36);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "نظام البحث عن الأدوية وإدارة الصيدليات";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPharmacy
            // 
            btnPharmacy.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPharmacy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPharmacy.ForeColor = System.Drawing.Color.White;
            btnPharmacy.Image = (System.Drawing.Image)resources.GetObject("btnPharmacy.Image");
            btnPharmacy.Location = new System.Drawing.Point(112, 377);
            btnPharmacy.Margin = new System.Windows.Forms.Padding(4);
            btnPharmacy.Name = "btnPharmacy";
            btnPharmacy.Size = new System.Drawing.Size(337, 66);
            btnPharmacy.TabIndex = 3;
            btnPharmacy.Text = "صيدلية";
            btnPharmacy.UseVisualStyleBackColor = false;
            btnPharmacy.Click += btnPharmacy_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUser.ForeColor = System.Drawing.Color.White;
            btnUser.Image = (System.Drawing.Image)resources.GetObject("btnUser.Image");
            btnUser.Location = new System.Drawing.Point(520, 377);
            btnUser.Margin = new System.Windows.Forms.Padding(4);
            btnUser.Name = "btnUser";
            btnUser.Size = new System.Drawing.Size(333, 66);
            btnUser.TabIndex = 4;
            btnUser.Text = "مستخدم";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1128, 554);
            Controls.Add(btnUser);
            Controls.Add(btnPharmacy);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(427, 305);
            Name = "MainForm";
            Text = "نضام البحث عن صيدليات الذكي";
            Controls.SetChildIndex(picLogo, 0);
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(lblSubtitle, 0);
            Controls.SetChildIndex(btnPharmacy, 0);
            Controls.SetChildIndex(btnUser, 0);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private AlAmanPharmacyUI.Controls.RoundedButton btnPharmacy;
        private AlAmanPharmacyUI.Controls.RoundedButton btnUser;
    }
}
