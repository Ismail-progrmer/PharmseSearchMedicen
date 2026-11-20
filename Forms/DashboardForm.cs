using System;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Forms
{

    public partial class DashboardForm : AlAmanPharmacyUI.Controls.ChromeForm
    {
        public int PharmacyID;
        public string PharmacyName;
        public DashboardForm(int pharmacyID, string pharmacyName)
        {
            InitializeComponent();
            PharmacyID = pharmacyID;
            PharmacyName = pharmacyName;

            lblWelcome.Text = " مرحباً بك في صيدلية: " + PharmacyName;
        }


        private void MedCard_Click(object sender, EventArgs e)
        {
            ManageMedicinesForm form = new ManageMedicinesForm(PharmacyID);
            form.ShowDialog();
        }


        private void PharmCard_Click(object sender, EventArgs e)
        {
            ManagePharmacyForm from = new ManagePharmacyForm(PharmacyID);
            from.Show();
            this.Hide();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form main = new MainForm();
            main.FormClosed += (s, args) => Application.Exit();
            Hide();
            main.Show();
        }

        private void pnlPharmCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
