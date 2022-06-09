using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Paciente
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtUsuario.Text = String.Empty; 
            cbShowPassword.Checked = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsuario.Text != "")
            {
                MessageBox.Show("Accediste");
                FrmMenu principal = new FrmMenu();
                this.Hide();
                principal.Show();

            }
            else
            {
                MessageBox.Show("Por favor llenar los campos vacios");
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
