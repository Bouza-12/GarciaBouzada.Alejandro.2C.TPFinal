using Entidades.Clases;
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
    }
}
