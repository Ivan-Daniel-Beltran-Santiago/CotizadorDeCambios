using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class FormC : Form
    {
        double num1, num2;
        String selectedOpera;

        public FormC()
        {
            InitializeComponent();
        }

        Clases.ClsPlus obj1 = new Clases.ClsPlus();
        Clases.ClsMinus obj2 = new Clases.ClsMinus();
        Clases.ClsMultiply obj3 = new Clases.ClsMultiply();
        Clases.ClsDivide obj4 = new Clases.ClsDivide();

        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "8";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtboxdata.Text);

            double Pls;
            double Min;
            double Mul;
            double Div;

            switch(selectedOpera)
            {
                case "+":
                    Pls = obj1.Plus((num1), (num2));
                    txtboxdata.Text = Pls.ToString();
                    break;
                case "-":
                    Min = obj2.Minus((num1), (num2));
                    txtboxdata.Text = Min.ToString();
                    break;
                case "*":
                    Mul = obj3.PMultiply((num1), (num2));
                    txtboxdata.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Divide((num1), (num2));
                    if (num2 == 0)
                    {
                        txtboxdata.Text = "Syntax ERROR";
                    } else
                    {
                        txtboxdata.Text = Div.ToString();
                    }
                    break;
             }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtboxdata.Clear();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxdata.Text = txtboxdata.Text + "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (!txtboxdata.Text.Contains("."))
            {
                if(txtboxdata.Text.Length < 1)
                {
                    txtboxdata.Text = txtboxdata.Text + "0.";
                } else
                {
                    txtboxdata.Text = txtboxdata.Text + ".";
                }
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            selectedOpera = "-";
            num1 = double.Parse(txtboxdata.Text);
            txtboxdata.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            selectedOpera = "*";
            num1 = double.Parse(txtboxdata.Text);
            txtboxdata.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            selectedOpera = "/";
            num1 = double.Parse(txtboxdata.Text);
            txtboxdata.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtboxdata.Text.Length <= 1)
            {
                txtboxdata.Text = "";
            }
            else
            {
                txtboxdata.Text = txtboxdata.Text.Substring(0, txtboxdata.Text.Length - 1);
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            selectedOpera = "+";
            num1 = double.Parse(txtboxdata.Text);
            txtboxdata.Clear();
        }
    }
}
