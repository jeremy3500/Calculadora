using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_01_Click(object sender, EventArgs e) { txtTextoo.Text += "1"; }
        private void btn_02_Click(object sender, EventArgs e) { txtTextoo.Text += "2"; }
        private void btn_03_Click(object sender, EventArgs e) { txtTextoo.Text += "3"; }
        private void btn_04_Click(object sender, EventArgs e) { txtTextoo.Text += "4"; }
        private void btn_05_Click(object sender, EventArgs e) { txtTextoo.Text += "5"; }
        private void btn_06_Click(object sender, EventArgs e) { txtTextoo.Text += "6"; }
        private void btn_07_Click(object sender, EventArgs e) { txtTextoo.Text += "7"; }
        private void btn_08_Click(object sender, EventArgs e) { txtTextoo.Text += "8"; }
        private void btn_09_Click(object sender, EventArgs e) { txtTextoo.Text += "9"; }
        private void btn_00_Click(object sender, EventArgs e) { txtTextoo.Text += "0"; }
        private void btn_Punto_Click(object sender, EventArgs e) { txtTextoo.Text += "."; }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNumeros.Text = "";
        }
        double n1, n2;
        string operation;
        private void btn_Multi_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtTextoo.Text);
            txtTextoo.Text += "x"; lblNumeros.Text = txtTextoo.Text;
            txtTextoo.Text = ""; operation = "multi";
        }

        private void button1_Click(object sender, EventArgs e) { txtTextoo.Text = ""; }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtTextoo.Text);
            txtTextoo.Text += "/"; lblNumeros.Text = txtTextoo.Text;
            txtTextoo.Text = ""; operation = "divi";
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtTextoo.Text);
            txtTextoo.Text += "-"; lblNumeros.Text = txtTextoo.Text;
            txtTextoo.Text = ""; operation = "resta";
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtTextoo.Text);
            txtTextoo.Text += "+"; lblNumeros.Text = txtTextoo.Text;
            txtTextoo.Text = ""; operation = "suma";
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(txtTextoo.Text);
                if (operation == "multi") txtTextoo.Text = (n1 * n2).ToString();
                if (operation == "divi") txtTextoo.Text = (n1 / n2).ToString();
                if (operation == "resta") txtTextoo.Text = (n1 - n2).ToString();
                if (operation == "suma") txtTextoo.Text = (n1 + n2).ToString();
                lblNumeros.Text = "";
            }catch(Exception ex) { MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
