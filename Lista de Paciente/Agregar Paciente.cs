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
    public partial class Agregar_Paciente : Form
    {
        public Agregar_Paciente()
        {
            InitializeComponent();
        }

        private void Agregar_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtnumber.Clear();
            dtpFechaNacimiento.Value.ToLocalTime();
            dpdProvincia.SelectedValue = 0;
            dpdSexo.SelectedValue = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IngresarPaciente ingresar = new IngresarPaciente();
            Random rnd = new Random();
            int idPaciente = rnd.Next(100000, 999999);
            if (txtNombre.Text == "" && txtApellido.Text == "" && txtnumber.Text == "" && txtCorreo.Text == "" && txtCedula.Text == "" && dpdSexo.Text == "" && dpdProvincia.Text == "")
            {
                MessageBox.Show("Por favor llene los campos vacios");
                return;
                
            }
            var ingresarPaciente = ingresar.Agregar( idPaciente,txtNombre.Text, txtApellido.Text, txtnumber.Text, txtCedula.Text, txtCorreo.Text, dpdProvincia.Text, dtpFechaNacimiento.Value.Date, dpdSexo.Text);
            if (ingresarPaciente)
            {
                
                MessageBox.Show("Se ha agregado el paciente");
                MessageBox.Show("ID del paciente es: "+idPaciente);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtCorreo.Clear();
                txtnumber.Clear();
                dtpFechaNacimiento.Value.ToLocalTime();
                dpdProvincia.SelectedValue = 0;
                dpdSexo.SelectedValue = 0;
            }
            
           
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
