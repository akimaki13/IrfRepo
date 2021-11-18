using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Ball : Label
    {
        public Ball() 
        {
            AutoSize = false;
            Height = 50;
            Width = 50;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g) 
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

        public void MoveBall() 
        {
            Left += 1;
        }

        public class BallFactory
        {
            public Ball CreateNew()
            {
                return new Ball();
            }
        }
    }


}
