using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas
{

    public partial class Form1 : Form
    {

        string resultado;
        string q0;
        string q1;
        string q2;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void txtQ1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQ3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtQ0_Enter(object sender, EventArgs e)
        {
            if(txtQ0.Text == "Ingrese q0"){
                txtQ0.Text = "";
                txtQ0.ForeColor = Color.SlateBlue;
            }
        }

        private void txtQ0_Leave(object sender, EventArgs e)
        {
            if (txtQ0.Text == "")
            {
                txtQ0.Text = "Ingrese q0";
                txtQ0.ForeColor = Color.Silver;
            }
        }


        private void txtQ1_Enter(object sender, EventArgs e)
        {
            if (txtQ1.Text == "Ingrese q1")
            {
                txtQ1.Text = "";
                txtQ1.ForeColor = Color.DarkViolet;
            }
        }

        private void txtQ1_Leave(object sender, EventArgs e)
        {
            if (txtQ1.Text == "")
            {
                txtQ1.Text = "Ingrese q1";
                txtQ1.ForeColor = Color.Silver;
            }
        }

        private void txtQ2_Enter(object sender, EventArgs e)
        {
            if (txtQ2.Text == "Ingrese q2")
            {
                txtQ2.Text = "";
                txtQ2.ForeColor = Color.Crimson;
            }
        }

        private void txtQ2_Leave(object sender, EventArgs e)
        {
            if (txtQ2.Text == "")
            {
                txtQ2.Text = "Ingrese q2";
                txtQ2.ForeColor = Color.Silver;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            q0 = txtQ0.Text;
            q1 = txtQ1.Text;
            q2 = txtQ2.Text;
            calcular(q0, q1, q2, 1);
        }


        public void calcular(string Q0, string Q1, string Q2, int rep)
        {
            if (Q2.Contains("q2"))
            {
                Q2 = Q2.Replace("q2", "*").Replace(" ", "").Replace("+", "");
            }
            else
            {
                Q2 = Q2.Replace(" ", "");
            }


            if (Q1.Contains("q1"))
            {
                Q1 = Q1.Replace("q1", "*").Replace(" ", "").Replace("+", "").Replace("q2", "(" + Q2 + ")");
            }
            else
            {
                Q1 = Q1.Replace(" ", "").Replace("q2", "(" + Q2 + ")");
            }


            if (Q0.Contains("q0"))
            {
                Q0 = Q0.Replace("q0", "*").Replace(" ", "").Replace("+", "").Replace("q2", "(" + Q2 + ")").Replace("q1", "(" + Q1 + ")");
            }
            else
            {
                Q0 = Q0.Replace(" ", "").Replace("q2", "(" + Q2 + ")").Replace("q1", "(" + Q1 + ")");
            }


            if (rep == 1)
            {
                calcular(Q0, Q1, Q2, 2);
            }
            else
            {
                Resultado(Q0, Q1, Q2);
            }
        }



        private void txtQ1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        public void Resultado(string var0, string var1, string var2)
        {
            var2 = var2.Replace("(E)", "");
            var1 = var1.Replace("(E)", "");
            var0 = var0.Replace("(E)", "");

            var0 = "q0 = " + var0;
            var1 = "q1 = " + var1;
            var2 = "q2 = " + var2;
            resultado = var0 + "\r\n" + var1 + "\r\n" + var2;
            txtResultado.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtQ0.Text = "Ingrese q0";
            txtQ0.ForeColor = Color.Silver;
            txtQ1.Text = "Ingrese q1";
            txtQ1.ForeColor = Color.Silver;
            txtQ2.Text = "Ingrese q2";
            txtQ2.ForeColor = Color.Silver;
            txtResultado.Text = "";
        }
    }
}
