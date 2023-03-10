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

            ///myGraphic.DrawLine(myPen1, 50, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด 
            ///myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            ///myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            ///myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            ////myGraphic.DrawArc(myPen17, 460, 10, 30, 90, 0, 360);
            ////myGraphic.DrawEllipse(myPen2, 300, 20, 100, 100);

            Pen myPen1 = new Pen(System.Drawing.Color.DarkOrange, 7);
            Pen myPen2 = new Pen(System.Drawing.Color.Red, 7);
            Pen myPen3 = new Pen(System.Drawing.Color.SeaGreen, 10);
            Pen myPen4 = new Pen(System.Drawing.Color.Blue, 10);
            Pen myPen5 = new Pen(System.Drawing.Color.DarkGray, 7);
            Pen myPen6 = new Pen(System.Drawing.Color.Purple, 43);
            Pen myPen7 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen8 = new Pen(System.Drawing.Color.White, 7);
            Pen myPen9 = new Pen(System.Drawing.Color.DeepPink, 20);
            Pen myPen10 = new Pen(System.Drawing.Color.Purple, 7);
            Pen myPen11 = new Pen(System.Drawing.Color.Khaki, 9);
            Pen myPen12 = new Pen(System.Drawing.Color.LightSalmon, 15);
            Pen myPen13 = new Pen(System.Drawing.Color.LightSalmon, 22);
            Pen myPen14 = new Pen(System.Drawing.Color.LightSalmon, 7);
            Pen myPen15 = new Pen(System.Drawing.Color.DarkGreen, 5);
            Pen myPen16 = new Pen(System.Drawing.Color.LawnGreen, 5);
            Pen myPen17 = new Pen(System.Drawing.Color.DarkSalmon, 10);



            SolidBrush mySolidBrush1 = new SolidBrush(Color.LightGreen);
            SolidBrush mySolidBrush2 = new SolidBrush(Color.Khaki);
            SolidBrush mySolidBrush3 = new SolidBrush(Color.LightSalmon);
            SolidBrush mySolidBrush4 = new SolidBrush(Color.Yellow);
            SolidBrush mySolidBrush5 = new SolidBrush(Color.AliceBlue);
            SolidBrush mySolidBrush6 = new SolidBrush(Color.BlueViolet);


            //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H 
            myGraphic.DrawLine(myPen3, 60, 40, 60, 140);                    // = เส้น|| *
            myGraphic.DrawLine(myPen3, 80, 40, 80, 80);                     // = เส้น|| **
            myGraphic.DrawLine(myPen3, 80, 100, 80, 140);                   // = เส้น|| ***
            myGraphic.DrawLine(myPen3, 100, 40, 100, 80);                   // = เส้น|| ****
            myGraphic.DrawLine(myPen3, 100, 100, 100, 140);                 // = เส้น|| *****
            myGraphic.DrawLine(myPen3, 120, 40, 120, 140);                  // = เส้น|| ******

            myGraphic.DrawLine(myPen3, 60, 40, 80, 40);                     // = เส้น__*
            myGraphic.DrawLine(myPen3, 80, 140, 60, 140);                   // = เส้น__**
            myGraphic.DrawLine(myPen3, 80, 80, 100, 80);                    // = เส้น__***
            myGraphic.DrawLine(myPen3, 80, 100, 100, 100);                  // = เส้น__****
            myGraphic.DrawLine(myPen3, 100, 40, 120, 40);                   // = เส้น__*****
            myGraphic.DrawLine(myPen3, 100, 140, 120, 140);                 // = เส้น__******


            myGraphic.FillRectangle(mySolidBrush1, 60, 40, 20, 100);        // = สี*
            myGraphic.FillRectangle(mySolidBrush1, 80, 80, 20, 20);         // = สี**
            myGraphic.FillRectangle(mySolidBrush1, 100, 40, 20, 100);       // = สี***
            //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H //นี่คือตัว H 


            //นี่คือตัว N //นี่คือตัว N//นี่คือตัว N //นี่คือตัว N/ /นี่คือตัว N//นี่คือตัว N//นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N 
            myGraphic.DrawLine(myPen1, 140, 40, 140, 140);                  // = เส้น||*
            myGraphic.DrawLine(myPen1, 160, 60, 160, 140);                  // = เส้น||**
            myGraphic.DrawLine(myPen1, 220, 40, 220, 140);                  // = เส้น||***
            myGraphic.DrawLine(myPen1, 200, 40, 200, 130);                  // = เส้น||****

            myGraphic.DrawLine(myPen1, 140, 40, 160, 40);                   // = เส้น__*
            myGraphic.DrawLine(myPen1, 140, 140, 160, 140);                 // = เส้น__**
            myGraphic.DrawLine(myPen1, 200, 40, 220, 40);                   // = เส้น__****

            myGraphic.DrawLine(myPen1, 160, 40, 200, 120);                  // = เส้น\\*
            myGraphic.DrawLine(myPen11, 157, 51, 203, 139);                 // = สี\\*
            myGraphic.DrawLine(myPen1, 160, 75, 195, 140);                  // = เส้น\\**

            myGraphic.FillRectangle(mySolidBrush2, 143, 43, 16, 97);        // = สี||*
            myGraphic.FillRectangle(mySolidBrush2, 202, 43, 16, 97);        // = สี||**
            myGraphic.DrawLine(myPen1, 195, 140, 220, 140);                 // = เส้น__***

            //นี่คือตัว N //นี่คือตัว N//นี่คือตัว N //นี่คือตัว N/ /นี่คือตัว N//นี่คือตัว N//นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N //นี่คือตัว N  


            //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y  //นี่คือตัว Y //นี่คือตัว Y
            myGraphic.DrawLine(myPen13, 336, 49, 300, 100);                 // = สี\\*
            myGraphic.FillRectangle(mySolidBrush3, 289, 74, 23, 64);        // = สี||*
            myGraphic.DrawLine(myPen13, 265, 51, 300, 100);                 // = \\*สี

            myGraphic.DrawLine(myPen14, 247, 46, 280, 46);                  // = สี--\\*   
            myGraphic.DrawLine(myPen14, 250, 49, 283, 49);                  // = สี--\\** 
            myGraphic.DrawLine(myPen14, 253, 53, 287, 51);                  // = สี--\\***


            myGraphic.DrawLine(myPen14, 320, 46, 352, 46);                  // = สี--//*
            myGraphic.DrawLine(myPen14, 319, 50, 349, 50);                  // = สี--\\**
            myGraphic.DrawLine(myPen14, 319, 51, 349, 51);                  // = สี--\\***

            myGraphic.DrawLine(myPen2, 240, 40, 285, 100);                  // = เส้น\\ *
            myGraphic.DrawLine(myPen2, 275, 40, 300, 75);                   // = เส้น\\ **

            myGraphic.DrawLine(myPen2, 360, 40, 315, 100);                  // = เส้น// *
            myGraphic.DrawLine(myPen2, 325, 40, 300, 75);                   // = เส้น//  **

            myGraphic.DrawLine(myPen2, 285, 100, 285, 140);                 // = เส้น|| *
            myGraphic.DrawLine(myPen2, 315, 100, 315, 140);                 // = เส้น|| **

            myGraphic.DrawLine(myPen2, 240, 40, 282, 40);                   // = เส้น__*
            myGraphic.DrawLine(myPen2, 285, 140, 315, 140);                 // = เส้น__**
            myGraphic.DrawLine(myPen2, 325, 40, 360, 40);                   // = เส้น__****

            //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y //นี่คือตัว Y  //นี่คือตัว Y //นี่คือตัว Y


            //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ  //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ
            myGraphic.FillRectangle(mySolidBrush6, 390, 50, 138, 28);     // = สี__*
            myGraphic.FillRectangle(mySolidBrush6, 400, 70, 122, 95);     // = สี__**

            myGraphic.DrawRectangle(myPen7, 390, 50, 140, 25);            // = สี่เหลี่ยมฝาปิดกล่อง
            myGraphic.DrawRectangle(myPen7, 400, 75, 120, 90);            // = ฐานกล่อง__


            myGraphic.DrawLine(myPen15, 425, 50, 425, 165);             // = เส้นริบบินซ้าย |
            myGraphic.DrawLine(myPen16, 430, 50, 430, 165);             // = เส้นริบบินซ้าย ||
            myGraphic.DrawLine(myPen15, 435, 50, 435, 165);             // = เส้นริบบินซ้าย |||

            myGraphic.DrawLine(myPen15, 485, 50, 485, 165);             // = เส้นริบบินขวา |
            myGraphic.DrawLine(myPen16, 490, 50, 490, 165);             // = เส้นริบบินขวา ||
            myGraphic.DrawLine(myPen15, 495, 50, 495, 165);             // = เส้นริบบินขวา |||
            //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ  //นี่คือกล่องของขวัญ //นี่คือกล่องของขวัญ


            //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2  //นี่คือ เลข 2 //นี่คือ เลข 2 
            myGraphic.FillRectangle(mySolidBrush4, 25, 190, 132, 40);        // = สี --*
            myGraphic.FillRectangle(mySolidBrush4, 25, 260, 132, 40);        // = สี --**
            myGraphic.FillRectangle(mySolidBrush4, 25, 330, 132, 40);        // = สี ---**
            myGraphic.FillRectangle(mySolidBrush4, 121, 190, 35, 100);       // = สี ||*
            myGraphic.FillRectangle(mySolidBrush4, 25, 260, 35, 110);        // = สี ||**

            myGraphic.DrawLine(myPen4, 25, 190, 25, 235);                    // = เส้น|| *
            myGraphic.DrawLine(myPen4, 160, 190, 160, 300);                  // = เส้น|| **
            myGraphic.DrawLine(myPen4, 120, 230, 120, 260);                  // = เส้น|| ***
            myGraphic.DrawLine(myPen4, 25, 260, 25, 370);                    // = เส้น|| ****
            myGraphic.DrawLine(myPen4, 60, 290, 60, 335);                    // = เส้น|| *****
            myGraphic.DrawLine(myPen4, 160, 330, 160, 370);                  // = เส้น|| ******

            myGraphic.DrawLine(myPen4, 25, 190, 160, 190);                   // = เส้น --*
            myGraphic.DrawLine(myPen4, 25, 230, 120, 230);                   // = เส้น --**
            myGraphic.DrawLine(myPen4, 25, 260, 120, 260);                   // = เส้น --***
            myGraphic.DrawLine(myPen4, 60, 295, 160, 295);                   // = ส้น --****
            myGraphic.DrawLine(myPen4, 60, 330, 160, 330);                   // = เส้น --*****
            myGraphic.DrawLine(myPen4, 25, 370, 160, 370);                   // = เส้น --******
            //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2  //นี่คือ เลข 2 //นี่คือ เลข 2 


            //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0  //นี่คือ เลข 0 //นี่คือ เลข 0
            myGraphic.DrawEllipse(myPen6, 195, 200, 100, 150);               // = 0วงนอก
            myGraphic.DrawEllipse(myPen9, 195, 200, 100, 150);               // = 0วงใน
            //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0 //นี่คือ เลข 0   //นี่คือ เลข 0 //นี่คือ เลข 0


            //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2  //นี่คือ เลข 2 //นี่คือ เลข 2 
            myGraphic.FillRectangle(mySolidBrush4, 330, 190, 132, 40);      // = สี --*
            myGraphic.FillRectangle(mySolidBrush4, 330, 260, 132, 40);      // = สี --**
            myGraphic.FillRectangle(mySolidBrush4, 330, 330, 132, 40);      // = สี --***
            myGraphic.FillRectangle(mySolidBrush4, 428, 190, 35, 100);      // = สี ||*
            myGraphic.FillRectangle(mySolidBrush4, 330, 260, 35, 110);      // = สี ||**

            myGraphic.DrawLine(myPen4, 330, 190, 330, 235);                  // = เส้น ||*                   
            myGraphic.DrawLine(myPen4, 465, 190, 465, 300);                  // = เส้น ||**
            myGraphic.DrawLine(myPen4, 425, 230, 425, 260);                  // = เส้น ||*** 
            myGraphic.DrawLine(myPen4, 330, 260, 330, 370);                  // = เส้น ||****
            myGraphic.DrawLine(myPen4, 365, 290, 365, 335);                  // = เส้น ||*****
            myGraphic.DrawLine(myPen4, 465, 330, 465, 370);                  // = เส้น ||******
            
            myGraphic.DrawLine(myPen4, 330, 190, 465, 190);                  // = เส้น --* 
            myGraphic.DrawLine(myPen4, 330, 230, 425, 230);                  // = เส้น --**
            myGraphic.DrawLine(myPen4, 330, 260, 425, 260);                  // = เส้น --*** 
            myGraphic.DrawLine(myPen4, 365, 295, 465, 295);                  // = เส้น --****
            myGraphic.DrawLine(myPen4, 360, 330, 465, 330);                  // = เส้น --*****
            myGraphic.DrawLine(myPen4, 330, 370, 465, 370);                  // = เส้น --******                       
            //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2 //นี่คือ เลข 2  //นี่คือ เลข 2 //นี่คือ เลข 2 


            //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3

            myGraphic.FillRectangle(mySolidBrush4, 485, 190, 132, 40);       // = สี --*
            myGraphic.FillRectangle(mySolidBrush4, 485, 260, 132, 40);       // = สี --**
            myGraphic.FillRectangle(mySolidBrush4, 485, 330, 132, 40);       // = สี --***
            myGraphic.FillRectangle(mySolidBrush4, 579, 190, 39, 180);       // = สี ||*

            myGraphic.DrawLine(myPen4, 485, 190, 620, 190);                  // = เส้น --*
            myGraphic.DrawLine(myPen4, 485, 230, 580, 230);                  // = เส้น --**
            myGraphic.DrawLine(myPen4, 485, 260, 580, 260);                  // = เส้น --***
            myGraphic.DrawLine(myPen4, 485, 295, 580, 295);                  // = เส้น --****
            myGraphic.DrawLine(myPen4, 485, 330, 580, 330);                  // = เส้น --*****
            myGraphic.DrawLine(myPen4, 485, 370, 620, 370);                  // = เส้น --******
           
            myGraphic.DrawLine(myPen4, 485, 190, 485, 235);                  // = เส้น ||*
            myGraphic.DrawLine(myPen4, 580, 230, 580, 260);                  // = เส้น ||**
            myGraphic.DrawLine(myPen4, 485, 260, 485, 295);                  // = เส้น ||***
            myGraphic.DrawLine(myPen4, 580, 295, 580, 330);                  // = เส้น ||****          
            myGraphic.DrawLine(myPen4, 485, 330, 485, 370);                  // = เส้น ||*****
            myGraphic.DrawLine(myPen4, 620, 190, 620, 370);                  // = เส้น ||******
            //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3 //นี่คือ เลข 3       

        }
    }
}

