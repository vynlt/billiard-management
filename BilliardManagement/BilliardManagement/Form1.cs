using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardManagement
{
    public partial class Form1 : Form
    {
        private Color colorBorder = Color.FromArgb(224, 224, 224);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.button29.Image = (Image)(new Bitmap(BilliardManagement.Properties.Resources.reload, new Size(this.button29.Height - 20, this.button29.Width - 20)));
            this.button29.ImageAlign = ContentAlignment.MiddleCenter;
            this.button20.Image = (Image)(new Bitmap(BilliardManagement.Properties.Resources.back, new Size(this.button29.Height - 20, this.button29.Width - 20)));
            this.button20.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(colorBorder), 2),
                    e.ClipRectangle);
        }

        public Color BorderColor
        {
            get
            {
                return colorBorder;
            }
            set
            {
                colorBorder = value;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

   

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
        }
    }
}
