using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       Calculadora  operacion = new Calculadora();

       int op=0, p=0;
       double num_1, num_2, resultado=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p == 0 && txtEntrada.TextLength < 12)
            {
                txtEntrada.Text = txtEntrada.Text + ",";
                p++;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "0"; 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(txtEntrada.TextLength<12)
            txtEntrada.Text = txtEntrada.Text + "7"; 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "8"; 
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "9"; 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "4"; 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "5"; 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "6"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "1"; 
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "2"; 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtEntrada.TextLength < 12)
            txtEntrada.Text = txtEntrada.Text + "3"; 
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
           
            switch (op)
            {
                case 1:
                    {
                        num_2 = double.Parse(txtEntrada.Text);
                        resultado = operacion.dividir(num_1, num_2);
                        break;

                    }

                case 2:
                    {
                        num_2 = double.Parse(txtEntrada.Text);
                        resultado = operacion.Sumar(num_1, num_2);
                        break;

                    }

                case 3:
                    {
                        num_2 = double.Parse(txtEntrada.Text);
                        resultado = operacion.restar(num_1, num_2);
                        break;

                    }

                case 4:
                    {
                        num_2 = double.Parse(txtEntrada.Text);
                        resultado = operacion.multiplicar(num_1, num_2);
                        break;

                    }
            }

            txtEntrada.Text = resultado.ToString();
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            p = 0;
            txtEntrada.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            p = 0;
            op = 1;
            num_1 = double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            p = 0;
            op = 2;
            num_1 = double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            p = 0;
            op = 4;
            num_1 = double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            p = 0;
            op = 3;
            num_1 = double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
        }
    }
}
