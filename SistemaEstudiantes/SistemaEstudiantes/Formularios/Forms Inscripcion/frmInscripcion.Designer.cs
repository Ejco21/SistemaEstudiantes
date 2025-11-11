namespace SistemaEstudiantes
{
    partial class frmInscripcion
    {
        private const string V = "frmInscripcion";

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

        private string GetName()
        {
            return Name;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvInscripcion = new DataGridView();
            btnInscribir = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscripcion).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripcion
            // 
            dgvInscripcion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripcion.Location = new Point(46, 29);
            dgvInscripcion.Name = "dgvInscripcion";
            dgvInscripcion.ReadOnly = true;
            dgvInscripcion.Size = new Size(712, 221);
            dgvInscripcion.TabIndex = 0;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(323, 281);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(173, 49);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(585, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(173, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(29, 337);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(173, 46);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInscribir);
            Controls.Add(dgvInscripcion);
            Name = "frmInscripcion";
            Text = "Inscripcion";
            Load += frmInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripcion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscripcion;
        private Button btnInscribir;
        private Button btnEliminar;
        private Button btnRegresar;
    }
}