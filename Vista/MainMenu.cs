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
            this.ActualizarListas();
        }
        /// <summary>
        /// Abre los Forms correspondiente al boton
        /// </summary>
        /// <param name="childForm"> El form que debe abrir</param>
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
            this.ActivarBoton(this.btnVerPacientes);
            this.OpenChildForm(new FrmPacientes(listaPacientes));
        }

        private void btnVerConsultas_Click(object sender, EventArgs e)
        {
            this.ActivarBoton(this.btnVerConsultas);
            this.OpenChildForm(new FrmVerConsultas(listaConsultas, listaPracticas));
        }


        private void btnGenerarConsultas_Click(object sender, EventArgs e)
        {
            this.ActivarBoton(this.btnGenerarConsultas);
            this.OpenChildForm(new FrmGenerarConsulta(listaConsultas, listaPacientes));
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            this.currentChildForm.Close();
            this.Inicio();
        }

        private void Inicio()
        {
            this.DesactivarBoton();
        }
        private void ActivarBoton(object senderBtn)
        {
            if (senderBtn is not null)
            {
                this.DesactivarBoton();
                this.ActualizarListas();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.Fuchsia;
                currentBtn.ForeColor = Color.Black;
            }
        }


        private void DesactivarBoton()
        {
            if (this.currentBtn is not null)
            {
                this.currentBtn.BackColor = Color.Indigo;
                this.currentBtn.ForeColor = Color.Gainsboro;
            }
        }

        private void ActualizarListas()
        {
            listaPacientes = SQLPaciente.ObtenerTodasLosPacientes();
            listaConsultas = SQLConsulta.ObtenerTodasLasConsutlas();
            listaPracticas = SQLPractica.ObtenerTodasLasPracticas();
        }

        private void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.currentChildForm.Close();
            this.Inicio();
        }
    }
}
