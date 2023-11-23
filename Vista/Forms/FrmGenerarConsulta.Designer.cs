namespace Vista.Forms
{
    partial class FrmGenerarConsulta
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
            dgrvConsultas = new DataGridView();
            dgrvPacientes = new DataGridView();
            btnAgregarConsulta = new Button();
            txtDescripcion = new TextBox();
            numIdPaciente = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            lblDescripcion = new Label();
            lblIdPaciente = new Label();
            lblIdPractica = new Label();
            lblPracticasAyuda = new Label();
            lblTituloGenerarConsultas = new Label();
            lblConsultas = new Label();
            lblListaPacientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgrvConsultas
            // 
            dgrvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvConsultas.Location = new Point(187, 75);
            dgrvConsultas.Name = "dgrvConsultas";
            dgrvConsultas.RowHeadersVisible = false;
            dgrvConsultas.RowTemplate.Height = 25;
            dgrvConsultas.Size = new Size(432, 113);
            dgrvConsultas.TabIndex = 0;
            // 
            // dgrvPacientes
            // 
            dgrvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvPacientes.Location = new Point(28, 194);
            dgrvPacientes.Name = "dgrvPacientes";
            dgrvPacientes.RowHeadersVisible = false;
            dgrvPacientes.RowTemplate.Height = 25;
            dgrvPacientes.Size = new Size(591, 150);
            dgrvPacientes.TabIndex = 1;
            // 
            // btnAgregarConsulta
            // 
            btnAgregarConsulta.Location = new Point(566, 403);
            btnAgregarConsulta.Name = "btnAgregarConsulta";
            btnAgregarConsulta.Size = new Size(90, 30);
            btnAgregarConsulta.TabIndex = 2;
            btnAgregarConsulta.Text = "Agregar";
            btnAgregarConsulta.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(99, 350);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // numIdPaciente
            // 
            numIdPaciente.Location = new Point(99, 379);
            numIdPaciente.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numIdPaciente.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIdPaciente.Name = "numIdPaciente";
            numIdPaciente.Size = new Size(97, 23);
            numIdPaciente.TabIndex = 4;
            numIdPaciente.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(99, 410);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 353);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción: ";
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(12, 381);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(68, 15);
            lblIdPaciente.TabIndex = 7;
            lblIdPaciente.Text = "Id Paciente:";
            // 
            // lblIdPractica
            // 
            lblIdPractica.AutoSize = true;
            lblIdPractica.Location = new Point(12, 412);
            lblIdPractica.Name = "lblIdPractica";
            lblIdPractica.Size = new Size(65, 15);
            lblIdPractica.TabIndex = 8;
            lblIdPractica.Text = "Id Práctica:";
            // 
            // lblPracticasAyuda
            // 
            lblPracticasAyuda.AutoSize = true;
            lblPracticasAyuda.BackColor = Color.Goldenrod;
            lblPracticasAyuda.Enabled = false;
            lblPracticasAyuda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPracticasAyuda.Location = new Point(227, 319);
            lblPracticasAyuda.Name = "lblPracticasAyuda";
            lblPracticasAyuda.Size = new Size(149, 114);
            lblPracticasAyuda.TabIndex = 9;
            lblPracticasAyuda.Text = "1 => Biodecodificación\r\n2 => Reiki\r\n3 => Tarot\r\n4 => Sakhmajat\r\n5 => Numerología\r\n6 => Carta Natal";
            lblPracticasAyuda.Visible = false;
            // 
            // lblTituloGenerarConsultas
            // 
            lblTituloGenerarConsultas.AutoSize = true;
            lblTituloGenerarConsultas.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloGenerarConsultas.Location = new Point(12, 9);
            lblTituloGenerarConsultas.Name = "lblTituloGenerarConsultas";
            lblTituloGenerarConsultas.Size = new Size(138, 21);
            lblTituloGenerarConsultas.TabIndex = 10;
            lblTituloGenerarConsultas.Text = "Generar Consultas";
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsultas.Location = new Point(28, 75);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(123, 19);
            lblConsultas.TabIndex = 11;
            lblConsultas.Text = "Lista de Consultas:";
            // 
            // lblListaPacientes
            // 
            lblListaPacientes.AutoSize = true;
            lblListaPacientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblListaPacientes.Location = new Point(27, 169);
            lblListaPacientes.Name = "lblListaPacientes";
            lblListaPacientes.Size = new Size(120, 19);
            lblListaPacientes.TabIndex = 12;
            lblListaPacientes.Text = "Lista de Pacientes:";
            // 
            // FrmGenerarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 445);
            ControlBox = false;
            Controls.Add(lblListaPacientes);
            Controls.Add(lblConsultas);
            Controls.Add(lblTituloGenerarConsultas);
            Controls.Add(lblPracticasAyuda);
            Controls.Add(lblIdPractica);
            Controls.Add(lblIdPaciente);
            Controls.Add(lblDescripcion);
            Controls.Add(numericUpDown1);
            Controls.Add(numIdPaciente);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregarConsulta);
            Controls.Add(dgrvPacientes);
            Controls.Add(dgrvConsultas);
            Name = "FrmGenerarConsulta";
            Load += FrmGenerarConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrvConsultas;
        private DataGridView dgrvPacientes;
        private Button btnAgregarConsulta;
        private TextBox txtDescripcion;
        private NumericUpDown numIdPaciente;
        private NumericUpDown numericUpDown1;
        private Label lblDescripcion;
        private Label lblIdPaciente;
        private Label lblIdPractica;
        private Label lblPracticasAyuda;
        private Label lblTituloGenerarConsultas;
        private Label lblConsultas;
        private Label lblListaPacientes;
    }
}