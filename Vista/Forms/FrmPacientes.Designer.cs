namespace Vista.Forms
{
    partial class FrmPacientes
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
            dgrvPacientes = new DataGridView();
            btnGuardarPacientesJson = new Button();
            lblTituloPacientes = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dateFechaNacimiento = new DateTimePicker();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblFechaNac = new Label();
            btnAgregarPaciente = new Button();
            numDni = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDni).BeginInit();
            SuspendLayout();
            // 
            // dgrvPacientes
            // 
            dgrvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvPacientes.Location = new Point(36, 45);
            dgrvPacientes.Name = "dgrvPacientes";
            dgrvPacientes.RowHeadersVisible = false;
            dgrvPacientes.RowTemplate.Height = 25;
            dgrvPacientes.Size = new Size(591, 177);
            dgrvPacientes.TabIndex = 0;
            // 
            // btnGuardarPacientesJson
            // 
            btnGuardarPacientesJson.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarPacientesJson.Location = new Point(534, 391);
            btnGuardarPacientesJson.Name = "btnGuardarPacientesJson";
            btnGuardarPacientesJson.Size = new Size(110, 30);
            btnGuardarPacientesJson.TabIndex = 1;
            btnGuardarPacientesJson.Text = "Guardar Json";
            btnGuardarPacientesJson.UseVisualStyleBackColor = true;
            btnGuardarPacientesJson.Click += btnGuardarPacientesJson_Click;
            // 
            // lblTituloPacientes
            // 
            lblTituloPacientes.AutoSize = true;
            lblTituloPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloPacientes.Location = new Point(36, 9);
            lblTituloPacientes.Name = "lblTituloPacientes";
            lblTituloPacientes.Size = new Size(131, 21);
            lblTituloPacientes.TabIndex = 2;
            lblTituloPacientes.Text = "Lista de Pacientes";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 251);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 280);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(258, 23);
            txtApellido.TabIndex = 4;
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(96, 339);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(200, 23);
            dateFechaNacimiento.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 254);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(18, 283);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(18, 312);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 9;
            lblDni.Text = "DNI:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(18, 332);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(72, 30);
            lblFechaNac.TabIndex = 10;
            lblFechaNac.Text = "Fecha de \r\nNacimiento:";
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(36, 391);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(110, 30);
            btnAgregarPaciente.TabIndex = 11;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // numDni
            // 
            numDni.Location = new Point(96, 310);
            numDni.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numDni.Minimum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numDni.Name = "numDni";
            numDni.Size = new Size(120, 23);
            numDni.TabIndex = 12;
            numDni.Value = new decimal(new int[] { 10000000, 0, 0, 0 });
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(652, 429);
            ControlBox = false;
            Controls.Add(numDni);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(lblFechaNac);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTituloPacientes);
            Controls.Add(btnGuardarPacientesJson);
            Controls.Add(dgrvPacientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPacientes";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Load += FrmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrvPacientes;
        private Button btnGuardarPacientesJson;
        private Label lblTituloPacientes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dateFechaNacimiento;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblFechaNac;
        private Button btnAgregarPaciente;
        private NumericUpDown numDni;
    }
}