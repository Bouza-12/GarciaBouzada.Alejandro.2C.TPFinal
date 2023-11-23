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
using Vista.Forms;

namespace Vista
{
    public partial class MainMenu : Form
    {
        private List<Practica> listaPracticas = new List<Practica>();
        private List<Paciente> listaPacientes = new List<Paciente>();
        protected List<Consulta> listaConsultas = new List<Consulta>();
        private Form currentChildForm;
        private Button currentBtn;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            listaPacientes = SQLPaciente.ObtenerTodasLosPacientes();
            listaConsultas = SQLConsulta.ObtenerTodasLasConsutlas();
            listaPracticas = SQLPractica.ObtenerTodasLasPracticas();
        }

        private void OpenChildForm(Form childForm)
        {
            //Revisar
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(childForm);
            panelFormularioHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(this.btnVerPacientes);
            OpenChildForm(new FrmPacientes(listaPacientes));
        }

        private void btnVerConsultas_Click(object sender, EventArgs e)
        {
            ActivarBoton(this.btnVerConsultas);
            OpenChildForm(new FrmVerConsultas(listaConsultas));
        }


        private void btnGenerarConsultas_Click(object sender, EventArgs e)
        {
            ActivarBoton(this.btnGenerarConsultas);
            OpenChildForm(new FrmGenerarConsulta(listaConsultas,listaPacientes));
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Inicio();
        }

        private void Inicio()
        {
            DesactivarBoton();
        }
        private void ActivarBoton(object senderBtn)
        {
            if (senderBtn is not null)
            {
                DesactivarBoton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.Fuchsia;
                currentBtn.ForeColor = Color.Black;
            }
        }


        private void DesactivarBoton()
        {
            if (currentBtn is not null)
            {
                currentBtn.BackColor = Color.Indigo;
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }
    }
}
