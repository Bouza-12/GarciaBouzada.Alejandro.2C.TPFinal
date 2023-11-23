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
        /// <summary>
        /// Agrega una consulta a la tabla Consulta de la Base de Datos TP2_2C_2023
        /// </summary>
        /// <param name="sender">boton de clic</param>
        /// <param name="e">evento clic</param>
        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            string descripcion = this.txtDescripcion.Text;
            int idPaciente = (int)this.numIdPaciente.Value;
            int idPractica = (int)this.numIdPractica.Value;
            if (descripcion is not null && descripcion != string.Empty &&
                idPaciente > 0 && idPaciente <= Paciente.GetMaxIdDePaciente(this.listaPaciente)
                && idPractica > 0 && idPractica < 7)
            {
                Consulta c = new Consulta(descripcion, idPaciente, idPractica);
                SQLConsulta.AgregarConsulta(c);
                this.RefrescarGridViews();
            }
        }

        private void numIdPractica_Enter(object sender, EventArgs e)
        {
            this.lblPracticasAyuda.Visible = true;
        }

        private void numIdPractica_Leave(object sender, EventArgs e)
        {
            this.lblPracticasAyuda.Visible = false;
        }
    }
}
