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
    public partial class Lista_de_pacientes : Form
    {
        public Lista_de_pacientes()
        {
            InitializeComponent();
            
        }
      


        private void Lista_de_pacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacienteDataSet.InfoPaciente' table. You can move, or remove it, as needed.
            this.infoPacienteTableAdapter.Fill(this.pacienteDataSet1.InfoPaciente);


        }

        private void filtrar(string criterio)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void infoPacienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

       
        private void IcoFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {

        
        }
    }
}
