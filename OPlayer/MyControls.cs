using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OPlayer
{
    public class MyProgressBar : Control
    {
        public MyProgressBar()
        {
            this.BackColor = Color.FromArgb(50, 50, 74);
            this.ForeColor = Color.WhiteSmoke;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            DoubleBuffered = true;


        }

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value >= Minimum && value <= Maximum)
                {
                    _value = value;
                    Invalidate();
                }
                else
                {
                    value = _value;
                }
            }
        }
        private int _minimum = 0;
        public int Minimum
        {
            get => _minimum;
            set
            {
                if (value < Maximum)
                {
                    _minimum = value;
                    if (_minimum > Value)
                    {
                        Value = _minimum;
                        Invalidate();
                    }
                }
                else
                {
                    value = _minimum;
                }
            }
        }
        private int _maximum;
        public int Maximum
        {
            get => _maximum;
            set
            {
                if (value > Minimum)
                {
                    _maximum = value;
                    Invalidate();
                }
                else
                {
                    value = _maximum;
                }
            }
        }
        public int Step { get; set; }

        public string Progress { get; set; }
        //private string _progress;
        //public string Progress
        //{
        //    get => _progress;
        //    set
        //    {
        //        _progress = Progress;
        //    }
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Rectangle rectProgress = new Rectangle(
                rect.X,
                rect.Y,
                CalculateProgressRectSize(rect),
                rect.Height);

            DrawBase(g, rect);
            DrawProgress(g, rectProgress);
            DrawBorder(g, rect);
            DrawText(g, Progress, rect);
        }

        public void DrawText(Graphics graph, string text, Rectangle rect)
        {
            Font normal_font = new Font("Arial", 8, FontStyle.Bold);
            StringFormat _stringFlags = new StringFormat();
            //  Rectangle rect = ClientRectangle;
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            graph.DrawString(text, normal_font, Brushes.Black, rect, new StringFormat(_stringFlags));
        }

        private int CalculateProgressRectSize(Rectangle rect)
        {
            int margin = Maximum - Minimum;
            return rect.Width * Value / margin;
        }

        private void DrawBase(Graphics graph, Rectangle rect)
        {
            // graph.DrawRectangle(new Pen(Color.White), rect);
            graph.FillRectangle(new SolidBrush(Color.White), rect);
        }

        private void DrawBorder(Graphics graph, Rectangle rect)
        {
            graph.DrawRectangle(new Pen(Color.Red), rect);
        }

        private void DrawProgress(Graphics graph, Rectangle rect)
        {
            if (rect.Width > 0)
            {
                LinearGradientBrush LGB = new LinearGradientBrush(rect, Color.Red, Color.White, 360);

                graph.DrawRectangle(new Pen(Color.Crimson), rect);
                graph.FillRectangle(new SolidBrush(Color.Crimson), rect);
            }
        }

        public bool PerformStep()
        {
            if (Value < Maximum)
            {
                if (Value + Step >= Maximum)
                {
                    Value = Maximum;
                    return false;
                }
                else
                {
                    Value += Step;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void ResetProgress()
        {
            Value = Minimum;
        }
    }
}
