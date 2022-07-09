using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class App2 : Form
    {
        public App2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.RebeccaPurple);
            Graphics graphics;
          
            graphics = pictureBox1.CreateGraphics();
            

            Point point1=(new Point(65,135));//izqInf
            Point point2 = (new Point(120,135));//DerInf
            Point point3 = (new Point(150, 105));
            Point point4 = (new Point(150, 65));
            Point point5 = (new Point(120, 35));
            Point point6 = (new Point(65, 35));
            Point point7 = (new Point(40, 65));
            Point point8 = (new Point(40, 105));

            Point[] points = { point1, point2,
                point3, point4,point5,
                point6 ,point7,point8
            };
            graphics.FillPolygon(myBrush, points);
            myBrush.Dispose();
            graphics.Dispose();
            //ahora el triangulo toca aquí abajo
            SolidBrush brush = new SolidBrush(Color.White);
            Graphics graphics2;
            Point points1 = new Point(110, 40);
            Point points2 = new Point(30, 170);
            Point points3 = new Point(220, 170);
            Point points4 = new Point(110, 40);
            Pen pen = new Pen(brush, 2);
            graphics2 = pictureBox1.CreateGraphics();
            PointF[] pointFs = { points1, points2, points3, points4 };
            graphics2.DrawLines(pen, pointFs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ahora el triangulo toca aquí abajo
            SolidBrush brush = new SolidBrush(Color.White);
            Graphics graphics2;
            Point points1 = new Point(110, 40);
            Point points2 = new Point(30, 170);
            Point points3 = new Point(220, 170);
            Point points4 = new Point(110, 40);
            Pen pen = new Pen(brush, 2);
            graphics2 = pictureBox1.CreateGraphics();
            PointF[] pointFs = { points1, points2, points3, points4 };
            graphics2.DrawLines(pen, pointFs);
            brush.Dispose();
            graphics2.Dispose();
            pen.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(Color.RebeccaPurple);
            Graphics graphics;

            graphics = pictureBox1.CreateGraphics();


            Point point1 = (new Point(65, 135));//izqInf
            Point point2 = (new Point(120, 135));//DerInf
            Point point3 = (new Point(150, 105));
            Point point4 = (new Point(150, 65));
            Point point5 = (new Point(120, 35));
            Point point6 = (new Point(65, 35));
            Point point7 = (new Point(40, 65));
            Point point8 = (new Point(40, 105));

            Point[] points = { point1, point2,
                point3, point4,point5,
                point6 ,point7,point8
            };
            graphics.FillPolygon(myBrush, points);
            myBrush.Dispose();
            graphics.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)

        {
            if(this.pictureBox1.BackColor == Color.Black){
                this.pictureBox1.BackColor = Color.Black;
                pictureBox1.Image = null;
            }
            else
                this.pictureBox1.BackColor = Color.Black;
        }
    }
}
