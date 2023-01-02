using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAPPA_NEW_YEAR_LAB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Red, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Green, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.Blue, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.DarkGray, 5);
            //Pen myPen2 = new Pen(System.Drawing.Color.Coral, 3);
            //myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //เส้นตรง//จุดเร่ิ่ม จุดสิ้นสุด 
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //สี่เหลี่ยม//จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //วงกลม//จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //เส้นโค้ง//จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            //นี่คือตัว H
            myGraphic.DrawLine(myPen1, 15, 15, 15, 140);    // = ||
            myGraphic.DrawLine(myPen1, 50, 95, 50, 140);    // = ||
            myGraphic.DrawLine(myPen1, 50, 15, 50, 60);     // = ||
            myGraphic.DrawLine(myPen4, 15, 15, 50, 15);     // = __
            myGraphic.DrawLine(myPen4, 15, 140, 50, 140);   // = __

            myGraphic.DrawLine(myPen2, 48, 60, 80, 60);     // = __
            myGraphic.DrawLine(myPen2, 48, 95, 80, 95);     // = __

            myGraphic.DrawLine(myPen3, 80, 15, 80, 63);     // = ||
            myGraphic.DrawLine(myPen3, 80, 95, 80, 140);    // = ||

            myGraphic.DrawLine(myPen4, 80, 15, 115, 15);    // = __
            myGraphic.DrawLine(myPen4, 80, 140, 115, 140);  // = __
            myGraphic.DrawLine(myPen1, 115, 15, 115, 140);  // = ||
                                                            //นี่คือตัว H 

            //Pen myPen1 = new Pen(System.Drawing.Color.Black, 5);
            //Pen myPen2 = new Pen(System.Drawing.Color.Red, 5);
            //Pen myPen3 = new Pen(System.Drawing.Color.Green, 5);
            //Pen myPen4 = new Pen(System.Drawing.Color.Blue, 5);
            //Pen myPen5 = new Pen(System.Drawing.Color.DarkGray, 5);

            //นี่คือตัว N
            myGraphic.DrawLine(myPen5, 150, 15, 150, 140);  // = ||
            myGraphic.DrawLine(myPen5, 185, 70, 185, 140);  // = ||

            myGraphic.DrawLine(myPen4, 185, 15, 150, 15);   // = __
            myGraphic.DrawLine(myPen4, 185, 140, 150, 140); // = __

            myGraphic.DrawLine(myPen2, 185, 15, 230, 95);   // = \\
            myGraphic.DrawLine(myPen2, 185, 70, 230, 140);  // = \\

            myGraphic.DrawLine(myPen4, 230, 15, 270, 15);   // = ____
            myGraphic.DrawLine(myPen4, 230, 140, 270, 140); // = ____

            myGraphic.DrawLine(myPen5, 270, 15, 270, 140);  // = ||
            myGraphic.DrawLine(myPen5, 230, 15, 230, 100);  // = ||
                                                            //นี่คือตัว N

            //Pen myPen1 = new Pen(System.Drawing.Color.Black, 5);
            //Pen myPen2 = new Pen(System.Drawing.Color.Red, 5);
            //Pen myPen3 = new Pen(System.Drawing.Color.Green, 5);
            //Pen myPen4 = new Pen(System.Drawing.Color.Blue, 5);
            //Pen myPen5 = new Pen(System.Drawing.Color.DarkGray, 5);

            //นี่คือตัว Y
            myGraphic.DrawLine(myPen4, 290, 15, 330, 15); // = __

            myGraphic.DrawLine(myPen2, 290, 15, 345, 85);   // = \\
            myGraphic.DrawLine(myPen2, 330, 15, 360, 55);   // = \\

            myGraphic.DrawLine(myPen5, 345, 85, 345, 140);  // = ||
            myGraphic.DrawLine(myPen4, 345, 140, 380, 140); // = __
            myGraphic.DrawLine(myPen5, 380, 85, 380, 140);  // = ||

            myGraphic.DrawLine(myPen2, 435, 15, 380, 85);   // = //  55
            myGraphic.DrawLine(myPen2, 395, 15, 360, 60);   // = //  45

            myGraphic.DrawLine(myPen4, 395, 15, 435, 15); // = __
                                                          //นี่คือตัว Y
        }
    }
}
