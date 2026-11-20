namespace AlAmanPharmacyUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picIllustration = new System.Windows.Forms.PictureBox();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new AlAmanPharmacyUI.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)picIllustration).BeginInit();
            SuspendLayout();
            // 
            // picIllustration
            // 
            picIllustration.BackColor = System.Drawing.Color.Transparent;
            picIllustration.Image = Properties.Resources._1795160030635;
            picIllustration.Location = new System.Drawing.Point(25, 73);
            picIllustration.Margin = new System.Windows.Forms.Padding(4);
            picIllustration.Name = "picIllustration";
            picIllustration.Size = new System.Drawing.Size(417, 457);
            picIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picIllustration.TabIndex = 0;
            picIllustration.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUsername.ForeColor = System.Drawing.Color.Blue;
            lblUsername.Location = new System.Drawing.Point(960, 211);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(189, 39);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "اسم المستخدم:";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.Location = new System.Drawing.Point(491, 220);
            txtUsername.Margin = new System.Windows.Forms.Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(448, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.ForeColor = System.Drawing.Color.Blue;
            lblPassword.Location = new System.Drawing.Point(970, 287);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(166, 39);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "كلمة المرور:";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(491, 296);
            txtPassword.Margin = new System.Windows.Forms.Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(448, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(30, 78, 140);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Image = (System.Drawing.Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new System.Drawing.Point(527, 379);
            btnLogin.Margin = new System.Windows.Forms.Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(443, 66);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "دخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1181, 582);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(picIllustration);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(427, 305);
            Name = "LoginForm";
            Text = "تسجيل الدخول";
            Controls.SetChildIndex(picIllustration, 0);
            Controls.SetChildIndex(lblUsername, 0);
            Controls.SetChildIndex(txtUsername, 0);
            Controls.SetChildIndex(lblPassword, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(btnLogin, 0);
            ((System.ComponentModel.ISupportInitialize)picIllustration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picIllustration;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private AlAmanPharmacyUI.Controls.RoundedButton btnLogin;
    }
}
