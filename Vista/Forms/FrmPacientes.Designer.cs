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
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).BeginInit();
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
            dgrvPacientes.Size = new Size(591, 150);
            dgrvPacientes.TabIndex = 0;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 445);
            ControlBox = false;
            Controls.Add(dgrvPacientes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPacientes";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FrmPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrvPacientes;
    }
}