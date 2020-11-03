using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Design;
using Image = System.Drawing.Image;

namespace Masivian
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBox1.Text);
            int valor2 = int.Parse(TextBox2.Text);
            int win;
            int finalv=0, color=0;
            float number;
            win = valor2 * 2;
            int index = CheckBoxList1.SelectedIndex;
            int count = CheckBoxList1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (valor1 > 0 && valor1 <= 36 && valor2 > 0 && valor2 <= 100000 && index == x)
                {
                    Random al = new Random();
                    number = al.Next(0, 360);
                    Grade(finalv,color,valor1,index,win,number);
                    //Rotate();
                }
            }
        }
        private void Grade(int finalv, int color, int valor1, int index, int win, float number){
            if (number > 0 && number < 9.47){finalv = 17;color = 0;Functn(finalv,color,valor1,index,win);}
            if (number > 9.47 && number <= 18.94){finalv = 25;color = 1;Functn(finalv,color,valor1,index,win);}
            if (number > 18.94 && number <= 28.41){finalv = 2;color = 0;Functn(finalv,color,valor1,index,win);}
            if (number > 28.41 && number <= 37.88){finalv = 21; color = 1; Functn(finalv, color, valor1, index, win);}
            if (number > 37.88 && number <= 47.35) { finalv = 4; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 47.35 && number <= 56.82) { finalv = 19; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 56.82 && number <= 66.29) { finalv = 15; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 66.29 && number <= 75.76) { finalv = 32; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 75.76 && number <= 85.23) { finalv = 0; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 85.23 && number <= 94.7) { finalv = 26; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 94.7 && number <= 104.17) { finalv = 3; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 104.17 && number <= 113.64) { finalv = 35; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 113.64 && number <= 123.11) { finalv = 12; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 123.11 && number <= 132.58) { finalv = 28; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 132.58 && number <= 142.05) { finalv = 7; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 142.05 && number <= 151.52) { finalv = 29; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 151.52 && number <= 160.99) { finalv = 18; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 160.99 && number <= 170.46) { finalv = 22; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 170.46 && number <= 179.93) { finalv = 9; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 179.93 && number <= 189.4) { finalv = 31; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 189.4 && number <= 198.87) { finalv = 14; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 198.87 && number <= 208.34) { finalv = 20; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 208.34 && number <= 217.81) { finalv = 1; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 217.81 && number <= 227.28) { finalv = 33; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 227.28 && number <= 236.75) { finalv = 16; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 236.75 && number <= 246.22) { finalv = 24; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 246.22 && number <= 255.69) { finalv = 5; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 255.69 && number <= 265.16) { finalv = 10; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 265.16 && number <= 274.63) { finalv = 23; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 274.63 && number <= 284.1) { finalv = 8; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 284.1 && number <= 293.57) { finalv = 30; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 293.57 && number <= 303.04) { finalv = 11; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 303.04 && number <= 312.51) { finalv = 36; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 312.51 && number <= 321.98) { finalv = 13; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 321.98 && number <= 331.45) { finalv = 27; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 331.45 && number <= 340.92) { finalv = 6; color = 1; Functn(finalv, color, valor1, index, win); }
            if (number > 340.92 && number <= 350.39) { finalv = 34; color = 0; Functn(finalv, color, valor1, index, win); }
            if (number > 350.39 && number <= 360.0) { finalv = 34; color = 1; Functn(finalv, color, valor1, index, win); }
        }
        private void Functn(int finalv, int color, int valor1, int index, int win){
            if (finalv == valor1 && color == index)
            {
                Label4.Text = "¡ERES EL GANADOR!, ganaste : " + win.ToString();
            }
            else
            {
                if (color == 0)
                {
                    Label4.Text = "¡Sigue intentando! cayó en " + finalv.ToString() + " Negro";
                }
                else
                {
                    Label4.Text = "¡Sigue intentando! cayó en " + finalv.ToString() + " Rojo";
                }
            }
        }
        private void Rotate()
        {
            throw new NotImplementedException();
        }
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[1].Selected == true)
                {
                    CheckBoxList1.Items[0].Selected = false;
                }
                else
                {
                    CheckBoxList1.Items[1].Selected = false;
                }
            }

        }
    }
}