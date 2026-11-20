using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlAmanPharmacyUI.Controls
{
    /// <summary>
    /// النموذج الأساسي لجميع نوافذ النظام: شريط عنوان مخصص بأسلوب عربي
    /// (الأيقونة والعنوان يمين الشاشة وأزرار التحكم يسارها) وزوايا دائرية.
    /// يوفر أيضاً التحقق التجريبي للتنقل بين النوافذ.
    /// </summary>
    public class ChromeForm : Form
    {
        private const int CornerRadius = 12;
        private const int ChromeHeight = 38;

        private Panel chromePanel;
        private PictureBox chromeIcon;
        private Label chromeTitle;
        private ChromeButton btnMin;
        private ChromeButton btnMax;
        private ChromeButton btnClose;
        private bool dragging;
        private Point dragOffset;

        /// <summary>
        /// ينشئ النموذج الأساسي ويبني شريط العنوان المخصص.
        /// </summary>
        public ChromeForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.White;
            Font = new Font(Theme.FontFamily, 9F);
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;
            MinimumSize = new Size(320, 220);
            BuildChrome();
            ApplyRegion();
        }

        private void BuildChrome()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ChromeForm));
            Icon = (Icon)resources.GetObject("$this.Icon");

            chromePanel = new Panel
            {
                BackColor = Theme.ChromeBar,
                Dock = DockStyle.Top,
                Height = ChromeHeight
            };
            chromePanel.MouseDown += Chrome_MouseDown;
            chromePanel.MouseMove += Chrome_MouseMove;
            chromePanel.MouseUp += Chrome_MouseUp;
            chromePanel.MouseDoubleClick += Chrome_DoubleClick;

            chromeIcon = new PictureBox
            {
                Size = new Size(20, 20),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Theme.ChromeBar,
                Image = (Image)resources.GetObject("chromeIcon")
            };
            chromeIcon.MouseDown += Chrome_MouseDown;
            chromeIcon.MouseMove += Chrome_MouseMove;
            chromeIcon.MouseUp += Chrome_MouseUp;

            chromeTitle = new Label
            {
                AutoSize = false,
                Font = new Font(Theme.FontFamily, 9.75F, FontStyle.Bold),
                ForeColor = Theme.NavyText,
                TextAlign = ContentAlignment.MiddleRight,
                BackColor = Color.Transparent
            };
            chromeTitle.MouseDown += Chrome_MouseDown;
            chromeTitle.MouseMove += Chrome_MouseMove;
            chromeTitle.MouseUp += Chrome_MouseUp;

            btnMin = new ChromeButton(ChromeGlyph.Minimize);
            btnMax = new ChromeButton(ChromeGlyph.Maximize);
            btnClose = new ChromeButton(ChromeGlyph.Close);
            btnMin.Click += (s, e) => WindowState = FormWindowState.Minimized;
            btnMax.Click += (s, e) => ToggleMaximize();
            btnClose.Click += (s, e) => Close();

            chromePanel.Controls.Add(chromeIcon);
            chromePanel.Controls.Add(chromeTitle);
            chromePanel.Controls.Add(btnMin);
            chromePanel.Controls.Add(btnMax);
            chromePanel.Controls.Add(btnClose);
            Controls.Add(chromePanel);
            LayoutChrome();
        }

        /// <summary>
        /// انتقال تجريبي بين النوافذ: إخفاء الحالية وإظهار نافذة أخرى،
        /// مع إعادة إظهار الحالية عند إغلاق النافذة الجديدة.
        /// </summary>
        protected void NavigateTo(Form next)
        {
            Form current = this;
            next.FormClosed += (s, e) =>
            {
                if (!current.IsDisposed)
                {
                    current.Show();
                }
            };
            next.Show();
            current.Hide();
        }

        /// <summary>
        /// ترتيب عناصر شريط العنوان حسب حجم النافذة.
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (chromePanel == null)
            {
                return;
            }
            LayoutChrome();
            ApplyRegion();
            Invalidate();
        }

        /// <summary>
        /// تحديث نص العنوان في الشريط المخصص.
        /// </summary>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (chromeTitle != null)
            {
                LayoutChrome();
            }
        }

        /// <summary>
        /// رسم إطار خارجي رقيق حول النافذة.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (WindowState == FormWindowState.Maximized)
            {
                return;
            }
            using (GraphicsPath path = UiPaint.RoundPath(new Rectangle(0, 0, Width - 1, Height - 1), CornerRadius))
            using (Pen pen = new Pen(Theme.ChromeBorder, 1.6F))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void LayoutChrome()
        {
            chromeTitle.Text = Text;
            chromeIcon.Location = new Point(chromePanel.Width - 30, 9);
            int titleWidth = TextRenderer.MeasureText(Text, chromeTitle.Font).Width;
            chromeTitle.SetBounds(chromePanel.Width - 34 - titleWidth - 6, 0, titleWidth + 8, ChromeHeight);
            btnMin.Location = new Point(8, 4);
            btnMax.Location = new Point(46, 4);
            btnClose.Location = new Point(84, 4);
        }

        private void ApplyRegion()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Region = null;
                return;
            }
            using (GraphicsPath path = UiPaint.RoundPath(new Rectangle(0, 0, Width, Height), CornerRadius))
            {
                Region = new Region(path);
            }
        }

        private void ToggleMaximize()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                ApplyRegion();
                Invalidate();
            }
            else
            {
                Region = null;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Chrome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragOffset = new Point(MousePosition.X - Left, MousePosition.Y - Top);
            }
        }

        private void Chrome_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && WindowState != FormWindowState.Maximized)
            {
                Location = new Point(MousePosition.X - dragOffset.X, MousePosition.Y - dragOffset.Y);
            }
        }

        private void Chrome_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Chrome_DoubleClick(object sender, MouseEventArgs e)
        {
            ToggleMaximize();
        }

        /// <summary>
        /// زر صغير يرسم رموز التحكم (تصغير/تكبير/إغلاق) بدقة.
        /// </summary>
        private enum ChromeGlyph
        {
            Minimize,
            Maximize,
            Close
        }

        private sealed class ChromeButton : Control
        {
            private const int SizeW = 36;
            private const int SizeH = 30;
            private readonly ChromeGlyph glyph;
            private bool hovered;

            public ChromeButton(ChromeGlyph glyph)
            {
                this.glyph = glyph;
                Size = new Size(SizeW, SizeH);
                BackColor = Theme.ChromeBar;
                Cursor = Cursors.Hand;
                SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer, true);
            }

            protected override void OnMouseEnter(EventArgs e)
            {
                hovered = true;
                Invalidate();
                base.OnMouseEnter(e);
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                hovered = false;
                Invalidate();
                base.OnMouseLeave(e);
            }

            protected override void OnPaintBackground(PaintEventArgs e)
            {
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                bool danger = glyph == ChromeGlyph.Close && hovered;
                Color back = danger ? Color.FromArgb(224, 96, 96)
                           : hovered ? Theme.ChromeBarHover
                           : BackColor;
                using (SolidBrush b = new SolidBrush(back))
                {
                    g.FillRectangle(b, ClientRectangle);
                }
                using (Pen p = new Pen(danger ? Color.White : Theme.ChromeGlyph, 1.8F))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    int cx = Width / 2;
                    int cy = Height / 2;
                    switch (glyph)
                    {
                        case ChromeGlyph.Minimize:
                            g.DrawLine(p, cx - 6, cy, cx + 6, cy);
                            break;
                        case ChromeGlyph.Maximize:
                            g.DrawRectangle(p, cx - 6, cy - 6, 12, 12);
                            break;
                        case ChromeGlyph.Close:
                            g.DrawLine(p, cx - 6, cy - 6, cx + 6, cy + 6);
                            g.DrawLine(p, cx - 6, cy + 6, cx + 6, cy - 6);
                            break;
                    }
                }
            }
        }
    }
}
