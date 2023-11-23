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
            btnGuardarJson = new Button();
            lblTotalConsultas = new Label();
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
            dgrvConsultas.Size = new Size(609, 177);
            dgrvConsultas.TabIndex = 1;
            // 
            // btnGuardarJson
            // 
            btnGuardarJson.Location = new Point(566, 403);
            btnGuardarJson.Name = "btnGuardarJson";
            btnGuardarJson.Size = new Size(90, 30);
            btnGuardarJson.TabIndex = 2;
            btnGuardarJson.Text = "Guardar Json";
            btnGuardarJson.UseVisualStyleBackColor = true;
            btnGuardarJson.Click += btnGuardarJson_Click;
            // 
            // lblTotalConsultas
            // 
            lblTotalConsultas.AutoSize = true;
            lblTotalConsultas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalConsultas.Location = new Point(478, 228);
            lblTotalConsultas.Name = "lblTotalConsultas";
            lblTotalConsultas.Size = new Size(46, 19);
            lblTotalConsultas.TabIndex = 3;
            lblTotalConsultas.Text = "Total:";
            // 
            // FrmVerConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(668, 445);
            ControlBox = false;
            Controls.Add(lblTotalConsultas);
            Controls.Add(btnGuardarJson);
            Controls.Add(dgrvConsultas);
            Name = "FrmVerConsultas";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Load += FrmVerConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvConsultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrvConsultas;
        private Button btnGuardarJson;
        private Label lblTotalConsultas;
    }
}