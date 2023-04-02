using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using SignalWithNoiseWFORMS;

namespace customDesignForWForms.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class textBox_ByIlya : UserControl
    {
        #region -> Поля
        private Color _borderColor = Color.MediumSlateBlue;
        private Color _borderFocusColor = Color.HotPink;
        private int _borderSize = 2;
        private bool _underlinedStyle = false;
        private bool _isFocused = false;

        private int _borderRadius = 0;
        private Color _placeholderColor = Color.DarkGray;
        private string _placeholderText = "";
        private bool _isPlaceholder = false;
        private bool _isPasswordChar = false;

        public event EventHandler _TextChanged;

        #endregion

        #region -> Свойства
        [Category("Ilya__Custom")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Ilya__Custom")]
        public Color BorderFocusColor
        {
            get { return _borderFocusColor; }
            set { _borderFocusColor = value; }
        }

        [Category("Ilya__Custom")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                if (value >= 0)
                {
                    _borderSize = value;
                    Invalidate();
                }
            }
        }

        [Category("Ilya__Custom")]
        public bool UnderlinedStyle
        {
            get { return _underlinedStyle; }
            set
            {
                _underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("Ilya__Custom")]
        public bool PasswordChar
        {
            get { return _isPasswordChar; }
            set
            {
                _isPasswordChar = value;
                if (!_isPlaceholder)
                    textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("Ilya__Custom")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Ilya__Custom")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Ilya__Custom")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Ilya__Custom")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Ilya__Custom")]
        public string Texts
        {
            get
            {
                if (_isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }

        [Category("Ilya__Custom")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                if (value >= 0)
                {
                    _borderRadius = value;
                    Invalidate();
                }
            }
        }

        [Category("Ilya__Custom")]
        public Color PlaceholderColor
        {
            get { return _placeholderColor; }
            set
            {
                _placeholderColor = value;
                if (_isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        [Category("Ilya__Custom")]
        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        #endregion

        public textBox_ByIlya()
        {
            InitializeComponent();
        }

        #region Переопределение методов
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (_borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize);
                int smoothSize = _borderSize > 0 ? _borderSize : 1;

                GraphicsPath pathBorderSmooth = Drawer.RoundedRectangle(rectBorderSmooth, _borderRadius);
                GraphicsPath pathBorder = Drawer.RoundedRectangle(rectBorder, _borderRadius - _borderSize);
                Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize);
                Pen penBorder = new Pen(_borderColor, _borderSize);

                Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                if (_borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = PenAlignment.Center;
                if (_isFocused) penBorder.Color = _borderFocusColor;

                if (_underlinedStyle) //Line Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else //Normal Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.DrawPath(penBorder, pathBorder);
                }

            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    Region = new Region(ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (_isFocused) penBorder.Color = _borderFocusColor;

                    if (_underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }
        #endregion

        #region Методы
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && _placeholderText != "")
            {
                _isPlaceholder = true;
                textBox1.Text = _placeholderText;
                textBox1.ForeColor = _placeholderColor;
                if (_isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (_isPlaceholder && _placeholderText != "")
            {
                _isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = ForeColor;
                if (_isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = Drawer.RoundedRectangle(textBox1.ClientRectangle, _borderRadius - _borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = Drawer.RoundedRectangle(textBox1.ClientRectangle, _borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
        #endregion

        #region TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            _isFocused = true;
            Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            _isFocused = false;
            Invalidate();
            SetPlaceholder();
        }
        #endregion
    }
}
