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

            Pen myPen1 = new Pen(System.Drawing.Color.DarkOrange, 7);
            Pen myPen2 = new Pen(System.Drawing.Color.Red, 7);
            Pen myPen3 = new Pen(System.Drawing.Color.SeaGreen, 7);
            Pen myPen4 = new Pen(System.Drawing.Color.Blue, 6);
            Pen myPen5 = new Pen(System.Drawing.Color.DarkGray, 5);


            SolidBrush mySolidBrush1 = new SolidBrush(Color.LightGreen);
            SolidBrush mySolidBrush2 = new SolidBrush(Color.Khaki);
            SolidBrush mySolidBrush3 = new SolidBrush(Color.LightSalmon);
            SolidBrush mySolidBrush4 = new SolidBrush(Color.AliceBlue);
            SolidBrush mySolidBrush5 = new SolidBrush(Color.AliceBlue);
            SolidBrush mySolidBrush6 = new SolidBrush(Color.AliceBlue);


            //นี่คือตัว H
            myGraphic.DrawLine(myPen3, 60, 40, 60, 140);                    // = || *
            myGraphic.DrawLine(myPen3, 80, 40, 80, 80);                     // = || **
            myGraphic.DrawLine(myPen3, 80, 100, 80, 140);                   // = || ***
            myGraphic.DrawLine(myPen3, 100, 40, 100, 80);                   // = || ****
            myGraphic.DrawLine(myPen3, 100, 100, 100, 140);                 // = || *****
            myGraphic.DrawLine(myPen3, 120, 40, 120, 140);                  // = || ******

            myGraphic.DrawLine(myPen3, 60, 40, 80, 40);                     // = __*
            myGraphic.DrawLine(myPen3, 80, 140, 60, 140);                   // = __**
            myGraphic.DrawLine(myPen3, 80, 80, 100, 80);                    // = __***
            myGraphic.DrawLine(myPen3, 80, 100, 100, 100);                  // = __****
            myGraphic.DrawLine(myPen3, 100, 40, 120, 40);                   // = __*****
            myGraphic.DrawLine(myPen3, 100, 140, 120, 140);                 // = __******


            myGraphic.FillRectangle(mySolidBrush1, 60, 40, 20, 100);        //*
            myGraphic.FillRectangle(mySolidBrush1, 80, 80, 20, 20);         //**
            myGraphic.FillRectangle(mySolidBrush1, 100, 40, 20, 100);       //***
            //นี่คือตัว H 


            //นี่คือตัว N
            myGraphic.DrawLine(myPen1, 140, 40, 140, 140);                  // = ||*
            myGraphic.DrawLine(myPen1, 160, 75, 160, 140);                  // = ||**
            myGraphic.DrawLine(myPen1, 220, 40, 220, 140);                  // = ||***
            myGraphic.DrawLine(myPen1, 200, 40, 200, 120);                  // = ||****

            myGraphic.DrawLine(myPen1, 140, 40, 160, 40);                   // = __*
            myGraphic.DrawLine(myPen1, 140, 140, 160, 140);                 // = __**
            myGraphic.DrawLine(myPen1, 195, 140, 220, 140);                 // = __***
            myGraphic.DrawLine(myPen1, 200, 40, 220, 40);                   // = __****

            myGraphic.DrawLine(myPen1, 160, 40, 200, 120);                  // = \\*
            myGraphic.DrawLine(myPen1, 160, 75, 195, 140);                  // = \\**

            myGraphic.FillRectangle(mySolidBrush2, 143, 43, 16, 97);        //*
            myGraphic.FillRectangle(mySolidBrush2, 202, 43, 16, 97);        //**



            //นี่คือตัว N


            //นี่คือตัว Y
            myGraphic.DrawLine(myPen2, 240, 40, 285, 100);                   // = \\ *
            myGraphic.DrawLine(myPen2, 275, 40, 300, 75);                    // = \\  **

            myGraphic.DrawLine(myPen2, 360, 40, 315, 100);                   // = // *
            myGraphic.DrawLine(myPen2, 325, 40, 300, 75);                    // = //  **

            myGraphic.DrawLine(myPen2, 285, 100, 285, 140);                  // = || *
            myGraphic.DrawLine(myPen2, 315, 100, 315, 140);                  // = || **

            myGraphic.DrawLine(myPen2, 240, 40, 280, 40);                    // = __*
            myGraphic.DrawLine(myPen2, 285, 140, 315, 140);                  // = __**
            myGraphic.DrawLine(myPen2, 325, 40, 360, 40);                    // = __****

            myGraphic.FillRectangle(mySolidBrush3, 289, 74, 23, 64);         //**


            //นี่คือตัว Y

            myGraphic.DrawLine(myPen4, 25, 190, 25, 235);                    // = || *

            myGraphic.DrawLine(myPen4, 140, 190, 140, 360);                    // = || *



            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //เส้นโค้ง//จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม
            //myGraphic.DrawArc(myPen1, 100, 100, 100, 100, 100, 50);
        }
    }
}
