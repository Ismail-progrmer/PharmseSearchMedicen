using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Forms
{
   
    public partial class LoginForm : AlAmanPharmacyUI.Controls.ChromeForm
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        private void OpenDashboard(int pharmacyID, string pharmacyName)
        {
            DashboardForm dashboard =new DashboardForm(pharmacyID, pharmacyName);

            dashboard.Show();

            this.Hide();
        }
        private void Login()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtUsername.Text)|| string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور","Waring", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                SELECT PharmaciesID, PharmacyName
                FROM Pharmacies
                WHERE UserName = :username
                AND Password = :password";

            try
            {
                using (OracleConnection con = Database.GetConnection())
                {
                    con.Open();

                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("username", username);
                        cmd.Parameters.Add("password", password);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int pharmacyID =
                                    Convert.ToInt32(reader["PharmaciesID"]);

                                string pharmacyName =
                                    reader["PharmacyName"].ToString();

                                OpenDashboard(pharmacyID, pharmacyName);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "اسم المستخدم أو كلمة المرور غير صحيحة",
                                    "فشل تسجيل الدخول",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Login();
        }
    }
}
