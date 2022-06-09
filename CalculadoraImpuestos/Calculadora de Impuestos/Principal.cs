using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Impuestos
{
    public partial class Principal : Form
    {
        static void Main()
        {
            Application.Run(new Principal());
        }

    
        public Principal()
        {
            InitializeComponent();
            

        }

        private void Principal_Load(object sender, System.EventArgs e)
        {

        }

        private void txtSueldo_TextChanged(object sender, System.EventArgs e)
        {
            //string pesoDom = "RD$";
            double sfs = 0.0304;
            double lbsfs = Convert.ToDouble(txtSueldo.Text) * sfs;
            txtSFS.Text = lbsfs.ToString();

            double afp = 0.0287;
            double lbafp = Convert.ToDouble(txtSueldo.Text) * afp;
            txtAFP.Text = lbafp.ToString();

            double semiSuma = lbsfs + lbafp;

            double isr = (Convert.ToDouble(txtSueldo.Text) - semiSuma)*12;
            if (isr <=416220.00)
            {
                txtISR.Text = "Exento";

                return;
            }
            if (isr >= 416220.01 && isr<=624329.00)
            {
                txtISR.Text = (((isr-416220.01 )* 0.15)/12).ToString(); 
                return;
            }
            if (isr >= 624329.01 && isr <= 867123.00)
            {
                txtISR.Text = ((((isr- 624329.01) * 0.20) + 31216.00) / 12).ToString();
                return;
            }
            if ((isr >= 867123.01 ))
            {
                txtISR.Text = (((((isr- 867123.01) * 0.25)+79776) / 12).ToString());
                return;
            }


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtSueldo.Text == "")
            {
                MessageBox.Show("Por favor no deje los campos vacios");
            }
            if (txtISR.Text == "Exento")
            {
                double resultadoISR = 0;
                double suma = Math.Abs(Convert.ToDouble(txtAFP.Text) + Convert.ToDouble(txtSFS.Text) + resultadoISR);
                double sueldoNeto = Math.Abs(suma - Convert.ToDouble(txtSueldo.Text));
                txtSueldoNeto.Text = sueldoNeto.ToString();
                return;
            }
            if (txtSueldo.Text != "")
            {
                string pesoDom = "RD$";
                double suma = (Convert.ToDouble(txtAFP.Text) + Convert.ToDouble(txtSFS.Text) + Convert.ToDouble(txtISR.Text));
                double sueldoNeto = Math.Abs(suma - Convert.ToDouble(txtSueldo.Text));
                txtSueldoNeto.Text = pesoDom+sueldoNeto.ToString();
                return;
            }
          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
