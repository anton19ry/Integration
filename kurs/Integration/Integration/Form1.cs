using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Integration
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double i = 0;
            string f;
            double c = 0;
            double P, p;
            p = Math.PI/2;
            P = Math.PI;





            a = double.Parse(textBox1.Text.ToString());
            b = double.Parse(textBox2.Text.ToString());
            c = double.Parse(textBox5.Text.ToString());
           
           
            f = textBox4.Text;
            if (f == "c")
            {
                i = ((b - a) / 6) * c*(a + 4 * ((a + b) / 2) + (b));
            }

            if (f == "x^c")
            {
                i = ((b - a) / 6) * (Math.Pow(a, c) + 4 * (Math.Pow(((a + b) / 2), c) + Math.Pow(b, c)));
            }

            if (f == "1/x")
            {
                i = ((b - a) / 6) * ((1 / (a)) + 4 * ((1 / ((a + b) / 2)) + (1 / (b))));
            }

            if (f == "1/(c^2+x^2)")
            {
                i = ((b - a) / 6) * ((1 / (Math.Pow(c, 2) + Math.Pow(a, 2))) + 4 * (1 / (Math.Pow(c, 2) + Math.Pow(((a + b) / 2), 2))) + (1 / (Math.Pow(c, 2) + Math.Pow(b, 2))));
            }


            if (f == "1/(x^2-c^2)")
            {
                i = ((b - a) / 6) * ((1 / (Math.Pow(a, 2) - Math.Pow(c, 2))) + 4 * (1 / (Math.Pow(((a + b) / 2), 2) - Math.Pow(c, 2))) + (1 / Math.Pow(b, 2) - Math.Pow(c, 2)));
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            if (f == "exp(x)")
            {
                i = ((b - a) / 6) * (Math.Exp(a) + 4 * (Math.Exp((a + b) / 2) + Math.Exp(b)));
            }


            if (f == "c^x")
            {
                i = ((b - a) / 6) * (Math.Pow(c, a) + 4 * (Math.Pow(c, ((a + b) / 2)) + Math.Pow(c, b)));
            }

            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            if (f == "1/(sqrt(c^2-x^2))")
            {
                i = ((b - a) / 6) * ((1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2))) + 4 * (1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(((a + b) / 2), 2))) + (1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2))));
            }


            if (f == "-1/(sqrt(c^2-x^2))")
            {
                i = ((b - a) / 6) * ((-1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2))) + 4 * (-1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(((a + b) / 2), 2))) + (-1 / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2))));
            }


            if (f == "1/(sqrt(x^2+c^2))")
            {
                i = ((b - a) / 6) * ((1 / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))) + 4 * (1 / Math.Sqrt(Math.Pow(((a + b) / 2), 2)) + Math.Pow(c, 2)) + (1 / Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))));
            }

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
             if (f == "cos(x)")
             {
                 i = ((b - a) / 6) * (Math.Cos(a) + 4 * (Math.Cos((a + b) / 2) + Math.Cos(b)));
             }

            
             if (f == "sin(x)")
             {
                 i = ((b - a) / 6) * (Math.Sin(a) + 4 * (Math.Sin((a + b) / 2) + Math.Sin(b)));
             }

         
             if (f == "1/(cos(x)^2)")
             {
                 i = ((b - a) / 6) * ((1 / Math.Pow(Math.Cos(a), 2)) + 4 * (1 / Math.Pow(Math.Cos((a + b) / 2), 2)) + (1 / Math.Pow(Math.Cos(b), 2)));
             }


             if (f == "1/(sin(x)^2)")
             {
                 i = ((b - a) / 6) * ((1 / Math.Pow(Math.Sin(a), 2)) + 4 * (1 / Math.Pow(Math.Sin((a + b) / 2), 2)) + (1 / Math.Pow(Math.Sin(b), 2)));
             }

            textBox3.Text = i.ToString();
           

        }



        private void очиститиДаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
        
    }

}