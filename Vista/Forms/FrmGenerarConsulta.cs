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
    public partial class FrmGenerarConsulta : Form
    {
        List<Consulta> listaConsultas;
        List<Paciente> listaPaciente;
        public FrmGenerarConsulta(List<Consulta> listaConsultas, List<Paciente> listaPaciente)
        {
            InitializeComponent();
            this.listaConsultas = listaConsultas;
            this.listaPaciente = listaPaciente;
        }

        private void FrmGenerarConsulta_Load(object sender, EventArgs e)
        {
            this.MostrarConsultas();
            this.MostrarPacientes();
        }

        /// <summary>
        /// Muestra el Data Grid View de Consultas
        /// </summary>
        private void MostrarConsultas()
        {
            dgrvConsultas.DataSource = listaConsultas;
        }
        /// <summary>
        /// Muestra el data gridview de pacientes
        /// </summary>
        private void MostrarPacientes()
        {
            this.dgrvPacientes.DataSource = this.listaPaciente;
            this.dgrvPacientes.Columns["RutaArchivo"].Visible = false;
            this.dgrvPacientes.Columns["Nombre"].Visible = false;
            this.dgrvPacientes.Columns["Apellido"].Visible = false;
        }
        /// <summary>
        /// Actualiza los data grid view del Formulario
        /// </summary>
        private void RefrescarGridViews()
        {
            this.listaPaciente = SQLPaciente.ObtenerTodasLosPacientes();
            this.MostrarPacientes();
            this.listaConsultas = SQLConsulta.ObtenerTodasLasConsutlas();
            this.MostrarConsultas();
        }
    }
}
