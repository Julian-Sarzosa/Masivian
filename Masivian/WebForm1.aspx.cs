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
            win = valor2 * 2;
            int index = CheckBoxList1.SelectedIndex;
            int count = CheckBoxList1.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (valor1 > 0 && valor1 <= 36 && valor2 > 0 && valor2 <= 100000 && index == x)
                {
                    Random al = new Random();
                    int number, value;
                    number = al.Next(0, 360);
                    //Rotate();
                    value = number / 10;
                    Label4.Text = "¡Sigue intentando! cayó en " + value.ToString();
                    if (number > 10)
                    {
                        if (number / 10 == valor1)
                        {
                            Label4.Text = "¡ERES EL GANADOR!, ganaste : " + win.ToString();
                        }
                    }
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