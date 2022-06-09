using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lista_de_Paciente
{
    public partial class FrmMenu : Form
    {
       
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Agregar_Paciente agregarPaciente = new Agregar_Paciente();
            agregarPaciente.Show();
            this.Hide();
            
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            Lista_de_pacientes listaPaciente = new Lista_de_pacientes();
            listaPaciente.Show();
            this.Hide();
        }
    }
}
