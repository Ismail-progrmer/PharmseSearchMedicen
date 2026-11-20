using System;
using System.Windows.Forms;

namespace AlAmanPharmacyUI
{
    /// <summary>
    /// نقطة انطلاق نظام صيدلية الأمان - يشغّل الواجهة الرئيسية.
    /// ملاحظة: هذا المشروع للتصميم المرئي فقط، ولا يحتوي أي منطق برمجي أو اتصال بقاعدة بيانات.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// نقطة الدخول الرئيسية للتطبيق.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AlAmanPharmacyUI.Forms.MainForm());
        }
    }
}
