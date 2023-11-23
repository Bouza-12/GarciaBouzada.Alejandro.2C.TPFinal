using Entidades.Clases;
using Entidades.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Forms
{
    public partial class FrmPacientes : Form
    {
        List<Paciente> listaPacientes;
        public FrmPacientes(List<Paciente> listaPacientes)
        {
            InitializeComponent();
            this.listaPacientes = listaPacientes;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            this.dgrvPacientes.DataSource = listaPacientes;
            this.dgrvPacientes.Columns["RutaArchivo"].Visible = false;
            this.dgrvPacientes.Columns["Nombre"].Visible = false;
            this.dgrvPacientes.Columns["Apellido"].Visible = false;
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            int dni = (int)this.numDni.Value;
            DateTime fechaNac = this.dateFechaNacimiento.Value;
            if (nombre is not null && nombre != string.Empty &&
                apellido is not null && apellido != string.Empty &&
                !Paciente.ExistePacientePorDni(listaPacientes, dni))
            {
                Paciente p = new Paciente(nombre, apellido, dni, fechaNac);
                SQLPaciente.AgregarPaciente(p);
                this.RefrescarGridViewPacientes();
            }
        }

        //puede ser hilo
        private void RefrescarGridViewPacientes()
        {
            this.listaPacientes = SQLPaciente.ObtenerTodasLosPacientes();
            this.MostrarPacientes();
        }

        private void btnGuardarPacientesJson_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar la lista en un archivo Json?","Guardar",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Paciente.GuardarEnArchivoJson(this.listaPacientes);
            }
        }
    }
}
