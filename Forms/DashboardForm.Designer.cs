namespace AlAmanPharmacyUI.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            lblWelcome = new System.Windows.Forms.Label();
            pnlMedCard = new AlAmanPharmacyUI.Controls.CardPanel();
            picMedIcon = new System.Windows.Forms.PictureBox();
            lblMedTitle = new System.Windows.Forms.Label();
            lblMedDesc = new System.Windows.Forms.Label();
            pnlPharmCard = new AlAmanPharmacyUI.Controls.CardPanel();
            picPharmIcon = new System.Windows.Forms.PictureBox();
            lblPharmTitle = new System.Windows.Forms.Label();
            lblPharmDesc = new System.Windows.Forms.Label();
            btnLogout = new AlAmanPharmacyUI.Controls.RoundedButton();
            pnlMedCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMedIcon).BeginInit();
            pnlPharmCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPharmIcon).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblWelcome.Location = new System.Drawing.Point(84, 76);
            lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(754, 61);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "مرحباً بك في نظام إدارة الصيدلية";
            lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMedCard
            // 
            pnlMedCard.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            pnlMedCard.Controls.Add(picMedIcon);
            pnlMedCard.Controls.Add(lblMedTitle);
            pnlMedCard.Controls.Add(lblMedDesc);
            pnlMedCard.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlMedCard.Location = new System.Drawing.Point(467, 174);
            pnlMedCard.Margin = new System.Windows.Forms.Padding(4);
            pnlMedCard.Name = "pnlMedCard";
            pnlMedCard.Size = new System.Drawing.Size(349, 282);
            pnlMedCard.TabIndex = 1;
            pnlMedCard.Click += MedCard_Click;
            // 
            // picMedIcon
            // 
            picMedIcon.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            picMedIcon.Image = (System.Drawing.Image)resources.GetObject("picMedIcon.Image");
            picMedIcon.Location = new System.Drawing.Point(140, 42);
            picMedIcon.Margin = new System.Windows.Forms.Padding(4);
            picMedIcon.Name = "picMedIcon";
            picMedIcon.Size = new System.Drawing.Size(69, 72);
            picMedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picMedIcon.TabIndex = 0;
            picMedIcon.TabStop = false;
            picMedIcon.Click += MedCard_Click;
            // 
            // lblMedTitle
            // 
            lblMedTitle.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMedTitle.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblMedTitle.Location = new System.Drawing.Point(13, 136);
            lblMedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMedTitle.Name = "lblMedTitle";
            lblMedTitle.Size = new System.Drawing.Size(323, 44);
            lblMedTitle.TabIndex = 1;
            lblMedTitle.Text = "إدارة الأدوية";
            lblMedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblMedTitle.Click += MedCard_Click;
            // 
            // lblMedDesc
            // 
            lblMedDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMedDesc.ForeColor = System.Drawing.Color.FromArgb(90, 107, 133);
            lblMedDesc.Location = new System.Drawing.Point(20, 186);
            lblMedDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMedDesc.Name = "lblMedDesc";
            lblMedDesc.Size = new System.Drawing.Size(309, 78);
            lblMedDesc.TabIndex = 2;
            lblMedDesc.Text = "إضافة وتعديل وحذف الأدوية";
            lblMedDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblMedDesc.Click += MedCard_Click;
            // 
            // pnlPharmCard
            // 
            pnlPharmCard.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            pnlPharmCard.Controls.Add(picPharmIcon);
            pnlPharmCard.Controls.Add(lblPharmTitle);
            pnlPharmCard.Controls.Add(lblPharmDesc);
            pnlPharmCard.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlPharmCard.Location = new System.Drawing.Point(64, 174);
            pnlPharmCard.Margin = new System.Windows.Forms.Padding(4);
            pnlPharmCard.Name = "pnlPharmCard";
            pnlPharmCard.Size = new System.Drawing.Size(349, 282);
            pnlPharmCard.TabIndex = 2;
            pnlPharmCard.Click += PharmCard_Click;
            pnlPharmCard.Paint += pnlPharmCard_Paint;
            // 
            // picPharmIcon
            // 
            picPharmIcon.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            picPharmIcon.Image = (System.Drawing.Image)resources.GetObject("picPharmIcon.Image");
            picPharmIcon.Location = new System.Drawing.Point(140, 42);
            picPharmIcon.Margin = new System.Windows.Forms.Padding(4);
            picPharmIcon.Name = "picPharmIcon";
            picPharmIcon.Size = new System.Drawing.Size(69, 72);
            picPharmIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picPharmIcon.TabIndex = 0;
            picPharmIcon.TabStop = false;
            picPharmIcon.Click += PharmCard_Click;
            // 
            // lblPharmTitle
            // 
            lblPharmTitle.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPharmTitle.ForeColor = System.Drawing.Color.FromArgb(23, 51, 94);
            lblPharmTitle.Location = new System.Drawing.Point(13, 136);
            lblPharmTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPharmTitle.Name = "lblPharmTitle";
            lblPharmTitle.Size = new System.Drawing.Size(323, 44);
            lblPharmTitle.TabIndex = 1;
            lblPharmTitle.Text = "إدارة الصيدلية";
            lblPharmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPharmTitle.Click += PharmCard_Click;
            // 
            // lblPharmDesc
            // 
            lblPharmDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPharmDesc.ForeColor = System.Drawing.Color.FromArgb(90, 107, 133);
            lblPharmDesc.Location = new System.Drawing.Point(20, 186);
            lblPharmDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPharmDesc.Name = "lblPharmDesc";
            lblPharmDesc.Size = new System.Drawing.Size(309, 78);
            lblPharmDesc.TabIndex = 2;
            lblPharmDesc.Text = "تعديل بيانات الصيدلية وأوقات العمل";
            lblPharmDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPharmDesc.Click += PharmCard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogout.ForeColor = System.Drawing.Color.White;
            btnLogout.Image = (System.Drawing.Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new System.Drawing.Point(320, 526);
            btnLogout.Margin = new System.Windows.Forms.Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(240, 64);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "تسجيل الخروج";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(210, 221, 238);
            ClientSize = new System.Drawing.Size(986, 665);
            Controls.Add(btnLogout);
            Controls.Add(pnlPharmCard);
            Controls.Add(pnlMedCard);
            Controls.Add(lblWelcome);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(427, 305);
            Name = "DashboardForm";
            Text = "لوحة التحكم";
            Controls.SetChildIndex(lblWelcome, 0);
            Controls.SetChildIndex(pnlMedCard, 0);
            Controls.SetChildIndex(pnlPharmCard, 0);
            Controls.SetChildIndex(btnLogout, 0);
            pnlMedCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMedIcon).EndInit();
            pnlPharmCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPharmIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private AlAmanPharmacyUI.Controls.CardPanel pnlMedCard;
        private System.Windows.Forms.PictureBox picMedIcon;
        private System.Windows.Forms.Label lblMedTitle;
        private System.Windows.Forms.Label lblMedDesc;
        private AlAmanPharmacyUI.Controls.CardPanel pnlPharmCard;
        private System.Windows.Forms.PictureBox picPharmIcon;
        private System.Windows.Forms.Label lblPharmTitle;
        private System.Windows.Forms.Label lblPharmDesc;
        private AlAmanPharmacyUI.Controls.RoundedButton btnLogout;
    }
}
