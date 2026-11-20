using System;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Forms
{
    
   
    public partial class MainForm : AlAmanPharmacyUI.Controls.ChromeForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            NavigateTo(new LoginForm());
        }

       
        private void btnUser_Click(object sender, EventArgs e)
        {
            NavigateTo(new SearchMedicineForm());
        }
    }
}
