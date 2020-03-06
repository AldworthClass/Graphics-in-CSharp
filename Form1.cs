using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_in_CSharp
{
    public partial class FormGraphics : Form
    {
        

        public FormGraphics()
        {
            InitializeComponent();
        }

        private void FormGraphics_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;    //Creates a graphics object to draw to, create a new one here so that it will always match the current properties of the Form

            SolidBrush redBrush = new SolidBrush(Color.Red);
            HatchBrush myHatchBrush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.Green);

            Pen redPen = new Pen(Color.Red, 5);
            Pen bluePen = new Pen(Color.Blue, 2);

            //canvas.Clear(Color.Black);
            //canvas.DrawLine(myRedPen, 10, 10, 300, 300);

           

            Point endPoint1 = new Point(10, 10);
            Point endPoint2 = new Point(this.ClientSize.Width, this.ClientSize.Height);
            canvas.DrawLine(redPen, endPoint1, endPoint2);


            //canvas.DrawLine(redPen, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            canvas.FillRectangle(myHatchBrush, 10, 10, 150, 150);
        }

        private void FormGraphics_Resize(object sender, EventArgs e)
        {
            this.Invalidate();      //Redraws graphics when resized
        }
    }
}
