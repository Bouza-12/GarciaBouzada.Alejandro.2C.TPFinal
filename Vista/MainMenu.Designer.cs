namespace Vista
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            btnGenerarConsultas = new Button();
            btnVerConsultas = new Button();
            btnVerPacientes = new Button();
            btnLogo = new Button();
            panelFormularioHijo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Indigo;
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnGenerarConsultas);
            panelMenu.Controls.Add(btnVerConsultas);
            panelMenu.Controls.Add(btnVerPacientes);
            panelMenu.Controls.Add(btnLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 461);
            panelMenu.TabIndex = 1;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(0, 300);
            button5.Name = "button5";
            button5.Size = new Size(200, 50);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(0, 250);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnGenerarConsultas
            // 
            btnGenerarConsultas.Dock = DockStyle.Top;
            btnGenerarConsultas.FlatStyle = FlatStyle.Flat;
            btnGenerarConsultas.ForeColor = Color.Gainsboro;
            btnGenerarConsultas.Location = new Point(0, 200);
            btnGenerarConsultas.Name = "btnGenerarConsultas";
            btnGenerarConsultas.Size = new Size(200, 50);
            btnGenerarConsultas.TabIndex = 3;
            btnGenerarConsultas.Text = "GenerarConsulta";
            btnGenerarConsultas.UseVisualStyleBackColor = true;
            btnGenerarConsultas.Click += btnGenerarConsultas_Click;
            // 
            // btnVerConsultas
            // 
            btnVerConsultas.Dock = DockStyle.Top;
            btnVerConsultas.FlatStyle = FlatStyle.Flat;
            btnVerConsultas.ForeColor = Color.Gainsboro;
            btnVerConsultas.Location = new Point(0, 150);
            btnVerConsultas.Name = "btnVerConsultas";
            btnVerConsultas.Size = new Size(200, 50);
            btnVerConsultas.TabIndex = 2;
            btnVerConsultas.Text = "Ver Consultas";
            btnVerConsultas.UseVisualStyleBackColor = true;
            btnVerConsultas.Click += btnVerConsultas_Click;
            // 
            // btnVerPacientes
            // 
            btnVerPacientes.Dock = DockStyle.Top;
            btnVerPacientes.FlatStyle = FlatStyle.Flat;
            btnVerPacientes.ForeColor = Color.Gainsboro;
            btnVerPacientes.Location = new Point(0, 100);
            btnVerPacientes.Name = "btnVerPacientes";
            btnVerPacientes.Size = new Size(200, 50);
            btnVerPacientes.TabIndex = 1;
            btnVerPacientes.Text = "Ver Pacientes";
            btnVerPacientes.UseVisualStyleBackColor = true;
            btnVerPacientes.Click += btnVerPacientes_Click;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.DarkViolet;
            btnLogo.Dock = DockStyle.Top;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Location = new Point(0, 0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(200, 100);
            btnLogo.TabIndex = 0;
            btnLogo.TextAlign = ContentAlignment.TopLeft;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.BackColor = Color.SteelBlue;
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(200, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(684, 461);
            panelFormularioHijo.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenu);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainMenu";
            Text = "Menú Principal";
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button5;
        private Button button4;
        private Button btnGenerarConsultas;
        private Button btnVerConsultas;
        private Button btnVerPacientes;
        private Button btnLogo;
        private Panel panelFormularioHijo;
    }
}