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
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgrvConsultas
            // 
            dgrvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvConsultas.Location = new Point(28, 12);
            dgrvConsultas.Name = "dgrvConsultas";
            dgrvConsultas.RowHeadersVisible = false;
            dgrvConsultas.RowTemplate.Height = 25;
            dgrvConsultas.Size = new Size(591, 138);
            dgrvConsultas.TabIndex = 0;
            // 
            // dgrvPacientes
            // 
            dgrvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvPacientes.Location = new Point(28, 171);
            dgrvPacientes.Name = "dgrvPacientes";
            dgrvPacientes.RowHeadersVisible = false;
            dgrvPacientes.RowTemplate.Height = 25;
            dgrvPacientes.Size = new Size(591, 150);
            dgrvPacientes.TabIndex = 1;
            // 
            // FrmGenerarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 445);
            ControlBox = false;
            Controls.Add(dgrvPacientes);
            Controls.Add(dgrvConsultas);
            Name = "FrmGenerarConsulta";
            Load += FrmGenerarConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrvConsultas;
        private DataGridView dgrvPacientes;
    }
}