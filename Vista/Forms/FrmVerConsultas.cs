﻿using Entidades.Clases;
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
        public FrmVerConsultas(List<Consulta> listaConsultas)
        {
            InitializeComponent();
            this.listaConsultas = listaConsultas;
        }

        private void FrmVerConsultas_Load(object sender, EventArgs e)
        {
            MostrarConsultas();
        }

        private void MostrarConsultas()
        {
            dgrvConsultas.DataSource = this.listaConsultas;
        }

        private void btnGuardarJson_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar la lista en un archivo Json?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Consulta.GuardarEnArchivoJson(this.listaConsultas);
            }
        }
    }
}
