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
    public partial class FrmVerConsultas : Form
    {
        private List<Consulta> listaConsultas;
        private List<Practica> listaPracticas;
        public FrmVerConsultas(List<Consulta> listaConsultas, List<Practica> listaPracticas)
        {
            InitializeComponent();
            this.listaConsultas = listaConsultas;
            this.listaPracticas = listaPracticas;
        }

        private void FrmVerConsultas_Load(object sender, EventArgs e)
        {
            this.MostrarConsultas();
            this.CalcularLblTotal(listaConsultas, listaPracticas, 0);
        }

        private void MostrarConsultas()
        {
            this.dgrvConsultas.DataSource = this.listaConsultas;
        }

        private void btnGuardarJson_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar la lista en un archivo Json?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Consulta.GuardarEnArchivoJson(listaConsultas);
            }
        }

        private void CalcularLblTotal(List<Consulta> listaConsultas, List<Practica> listaPreacticas, int id)
        {
            int total = 0;
            if (id == 0)
            {
                total = Consulta.PrecioTotalGastado(listaConsultas, listaPreacticas);
            }
            else
            {
                total = Consulta.PrecioTotalGastadoPorPersonaPorId(listaConsultas, listaPreacticas, id);
            }
            lblTotalConsultas.Text = $"Total: ${total}";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idIngresado = (int) this.numIdPaciente.Value;
            int MaxId = this.listaConsultas[listaConsultas.Count - 1].Id;
            if(idIngresado == 0 || idIngresado >MaxId) 
            {
                this.CalcularLblTotal(listaConsultas, listaPracticas, 0);
            }
            else
            {
                this.CalcularLblTotal(listaConsultas, listaPracticas, idIngresado);
            }
        }
    }
}
