using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Controls
{
    /// <summary>
    /// زر عصري بخلفية ملونة وزوايا دائرية، مع رسم الأيقونة يمين النص
    /// (باتجاه القراءة العربية) كما في التصميم المرجعي.
    /// </summary>
    public class RoundedButton : Button
    {
        private int cornerRadius = 12;
        private bool hovered;
        private bool pressed;

        /// <summary>
        /// ينشئ زراً جديداً بالشكل الافتراضي (أزرق داكن، نص أبيض).
        /// </summary>
        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Theme.Primary;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
        }

        /// <summary>
        /// نصف قطر زوايا الزر بالبكسل.
        /// </summary>
        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.DefaultValue(12)]
        [System.ComponentModel.Description("نصف قطر زوايا الزر")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value < 0 ? 0 : value;
                Invalidate();
            }
        }

        private Color CurrentFill
        {
            get
            {
                if (!Enabled)
                {
                    return Theme.PrimaryDisabled;
                }
                if (pressed)
                {
                    return Theme.PrimaryPressed;
                }
                if (hovered)
                {
                    return Theme.PrimaryHover;
                }
                return BackColor;
            }
        }

        /// <summary>
        /// يمنع تعبئة الخلفية المربعة الافتراضية حتى لا تظهر الزوايا.
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        /// <summary>
        /// يرسم الزر بخلفية دائرية ثم النص والأيقونة متراكزين.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = UiPaint.RoundPath(rect, cornerRadius))
            using (SolidBrush fill = new SolidBrush(CurrentFill))
            {
                g.FillPath(fill, path);
            }

            bool hasText = !string.IsNullOrEmpty(Text);
            int imageWidth = Image != null ? Image.Width : 0;
            int textWidth = hasText ? TextRenderer.MeasureText(Text, Font).Width : 0;
            int gap = Image != null && hasText ? 9 : 0;
            int total = textWidth + gap + imageWidth;
            int start = Math.Max(0, (Width - total) / 2);

            // الأيقونة يمين النص باتجاه القراءة العربية
            if (Image != null)
            {
                int iconY = (Height - Image.Height) / 2;
                g.DrawImage(Image, start + textWidth + gap, iconY);
            }
            if (hasText)
            {
                Rectangle textRect = new Rectangle(start, 0, textWidth + 6, Height);
                TextRenderer.DrawText(g, Text, Font, textRect, ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
            }
        }

        /// <summary>
        /// يقص زوايا الزر لتظهر دائرية فعلياً.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (GraphicsPath path = UiPaint.RoundPath(new Rectangle(0, 0, Width, Height), cornerRadius))
            {
                Region = new Region(path);
            }
        }

        /// <summary>
        /// حالات مرور الفأرة والضغط لتغيير لون الزر.
        /// </summary>
        protected override void OnMouseEnter(EventArgs e)
        {
            hovered = true;
            Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            hovered = false;
            pressed = false;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pressed = true;
            }
            Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            pressed = false;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            Invalidate();
            base.OnEnabledChanged(e);
        }
    }
}
