namespace Vista.Forms
{
    partial class FrmVerConsultas
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
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).BeginInit();
            SuspendLayout();
            // 
            // dgrvConsultas
            // 
            dgrvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvConsultas.Location = new Point(28, 39);
            dgrvConsultas.Name = "dgrvConsultas";
            dgrvConsultas.RowHeadersVisible = false;
            dgrvConsultas.RowTemplate.Height = 25;
            dgrvConsultas.Size = new Size(474, 269);
            dgrvConsultas.TabIndex = 1;
            // 
            // FrmVerConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 445);
            ControlBox = false;
            Controls.Add(dgrvConsultas);
            Name = "FrmVerConsultas";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Load += FrmVerConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrvConsultas;
    }
}