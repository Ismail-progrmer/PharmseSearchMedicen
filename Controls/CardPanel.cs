using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Controls
{
    /// <summary>
    /// بطاقة بلون فاتح وزوايا دائرية وإطار أزرق خفيف (لوحة التحكم).
    /// </summary>
    public class CardPanel : Panel
    {
        private int cornerRadius = 16;

        /// <summary>
        /// ينشئ بطاقة جديدة بالشكل الافتراضي.
        /// </summary>
        public CardPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            BackColor = Theme.CardFill;
        }

        /// <summary>
        /// نصف قطر زوايا البطاقة بالبكسل.
        /// </summary>
        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.DefaultValue(16)]
        [System.ComponentModel.Description("نصف قطر زوايا البطاقة")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value < 0 ? 0 : value;
                Invalidate();
            }
        }

        /// <summary>
        /// يمنع تعبئة الخلفية المربعة الافتراضية.
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        /// <summary>
        /// يرسم ظلاً خفيفاً أسفل يمين البطاقة ثم خلفيتها الدائرية وإطارها.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // الظل الخفيف (منزاح بضع بكسلات أسفل يمين البطاقة)
            Rectangle shadowRect = new Rectangle(3, 4, Width - 4, Height - 5);
            using (GraphicsPath shadowPath = UiPaint.RoundPath(shadowRect, cornerRadius))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(80, 130, 158, 196)))
            {
                g.FillPath(shadowBrush, shadowPath);
            }
            // جسم البطاقة
            Rectangle rect = new Rectangle(0, 0, Width - 4, Height - 5);
            using (GraphicsPath path = UiPaint.RoundPath(rect, cornerRadius))
            {
                using (SolidBrush fill = new SolidBrush(BackColor))
                {
                    g.FillPath(fill, path);
                }
                using (Pen border = new Pen(Theme.CardBorder, 1.6F))
                {
                    g.DrawPath(border, path);
                }
            }
        }

        /// <summary>
        /// يقص زوايا البطاقة.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (GraphicsPath path = UiPaint.RoundPath(new Rectangle(0, 0, Width, Height), cornerRadius))
            {
                Region = new Region(path);
            }
        }
    }
}
