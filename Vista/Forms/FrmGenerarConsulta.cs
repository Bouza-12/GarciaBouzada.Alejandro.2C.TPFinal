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
            MostrarConsultas();
            MostrarPacientes();
        }

        private void MostrarConsultas()
        {
            dgrvConsultas.DataSource = listaConsultas;
        }
        private void MostrarPacientes()
        {
            this.dgrvPacientes.DataSource = this.listaPaciente;
        }
    }
}
