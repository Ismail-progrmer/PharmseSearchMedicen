using System.Drawing;
using System.Drawing.Drawing2D;

namespace AlAmanPharmacyUI.Controls
{
    /// <summary>
    /// الهوية البصرية الموحدة لنظام صيدلية الأمان (ألوان، خطوط).
    /// </summary>
    public static class Theme
    {
        /// <summary>الأزرق الداكن الأساسي للأزرار والعناوين.</summary>
        public static readonly Color Primary = Color.FromArgb(30, 78, 140);

        /// <summary>أزرق أفتح عند مرور الفأرة.</summary>
        public static readonly Color PrimaryHover = Color.FromArgb(44, 98, 174);

        /// <summary>أزرق أغمق عند الضغط.</summary>
        public static readonly Color PrimaryPressed = Color.FromArgb(21, 60, 116);

        /// <summary>أزرق باهت عند التعطيل.</summary>
        public static readonly Color PrimaryDisabled = Color.FromArgb(140, 163, 199);

        /// <summary>لون نصوص العناوين والكلمات الرئيسية.</summary>
        public static readonly Color NavyText = Color.FromArgb(23, 51, 94);

        /// <summary>لون النصوص الثانوية والوصف.</summary>
        public static readonly Color SubText = Color.FromArgb(90, 107, 133);

        /// <summary>خلفية شريط العنوان المخصص.</summary>
        public static readonly Color ChromeBar = Color.FromArgb(201, 216, 238);

        /// <summary>خلفية شريط العنوان عند مرور الفأرة على الأزرار.</summary>
        public static readonly Color ChromeBarHover = Color.FromArgb(178, 198, 227);

        /// <summary>لون رموز أزرار التحكم (تصغير/تكبير/إغلاق).</summary>
        public static readonly Color ChromeGlyph = Color.FromArgb(23, 51, 94);

        /// <summary>إطار النافذة الخارجي.</summary>
        public static readonly Color ChromeBorder = Color.FromArgb(164, 188, 219);

        /// <summary>خلفية ترويسات جدول الأدوية.</summary>
        public static readonly Color GridHeader = Color.FromArgb(195, 211, 234);

        /// <summary>لون خطوط شبكة الجدول.</summary>
        public static readonly Color GridLine = Color.FromArgb(214, 224, 239);

        /// <summary>خلفية البطاقات في لوحة التحكم.</summary>
        public static readonly Color CardFill = Color.FromArgb(234, 243, 252);

        /// <summary>إطار البطاقات.</summary>
        public static readonly Color CardBorder = Color.FromArgb(159, 185, 220);

        /// <summary>الخط الافتراضي للنصوص.</summary>
        public static readonly string FontFamily = "Tahoma";
    }

    /// <summary>
    /// أدوات مساعدة للرسم (المسارات الدائرية).
    /// </summary>
    public static class UiPaint
    {
        /// <summary>
        /// ينشئ مسار مستطيل بزوايا دائرية.
        /// </summary>
        public static GraphicsPath RoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            if (radius <= 0 || rect.Width < diameter || rect.Height < diameter)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180F, 90F);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270F, 90F);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0F, 90F);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90F, 90F);
            path.CloseFigure();
            return path;
        }
    }
}
