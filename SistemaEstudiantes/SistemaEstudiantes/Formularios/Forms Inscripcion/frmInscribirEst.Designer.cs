namespace SistemaEstudiantes.Formularios.Forms_Inscripcion
{
    partial class frmInscribirEst
    {
        private const bool V = true;

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
            btnRegresar = new Button();
            btnInscribir = new Button();
            cbxCarrera = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNie = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            dtpNacimiento = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDireccion = new TextBox();
            label8 = new Label();
            cbxGenero = new ComboBox();
            label9 = new Label();
            cbxCiclo = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ltbObservaciones = new ListBox();
            label13 = new Label();
            cbxEstado = new ComboBox();
            txtAnio_Academico = new TextBox();
            mtbTelefono = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 383);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 49);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(557, 383);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(119, 49);
            btnInscribir.TabIndex = 19;
            btnInscribir.Text = "Inscribir";
            btnInscribir.Click += btnInscribir_Click;
            // 
            // cbxCarrera
            // 
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Items.AddRange(new object[] { "Desarrollo de Software", "Gastronomía" });
            cbxCarrera.Location = new Point(138, 30);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(121, 23);
            cbxCarrera.TabIndex = 1;
            cbxCarrera.Text = "elige";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 33);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Carrera:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 161);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Asignar Nie:";
            // 
            // txtNie
            // 
            txtNie.Location = new Point(138, 158);
            txtNie.MaxLength = 6;
            txtNie.Name = "txtNie";
            txtNie.Size = new Size(100, 23);
            txtNie.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 207);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 204);
            txtNombre.MaxLength = 61234123;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 23);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 253);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(138, 250);
            txtApellidos.MaxLength = 612341234;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(148, 23);
            txtApellidos.TabIndex = 8;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(138, 298);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(168, 23);
            dtpNacimiento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 298);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 10;
            label5.Text = "Fecha nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 32);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 11;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(435, 29);
            txtEmail.MaxLength = 1234234123;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(148, 23);
            txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 83);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(435, 80);
            txtDireccion.MaxLength = 132412341;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(148, 23);
            txtDireccion.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 130);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 15;
            label8.Text = "Telefono:";
            label8.Click += label8_Click;
            // 
            // cbxGenero
            // 
            cbxGenero.FormattingEnabled = true;
            cbxGenero.Items.AddRange(new object[] { "Masculino\t", "Femenino" });
            cbxGenero.Location = new Point(435, 173);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(121, 23);
            cbxGenero.TabIndex = 17;
            cbxGenero.Text = "elige";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 176);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 18;
            label9.Text = "Genero";
            // 
            // cbxCiclo
            // 
            cbxCiclo.FormattingEnabled = true;
            cbxCiclo.Items.AddRange(new object[] { "1", "2" });
            cbxCiclo.Location = new Point(138, 75);
            cbxCiclo.Name = "cbxCiclo";
            cbxCiclo.Size = new Size(121, 23);
            cbxCiclo.TabIndex = 20;
            cbxCiclo.Text = "elige";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 78);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 21;
            label10.Text = "Ciclo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 117);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 23;
            label11.Text = "Año académico";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(337, 232);
            label12.Name = "label12";
            label12.Size = new Size(87, 15);
            label12.TabIndex = 25;
            label12.Text = "Observaciones:";
            // 
            // ltbObservaciones
            // 
            ltbObservaciones.FormattingEnabled = true;
            ltbObservaciones.ItemHeight = 15;
            ltbObservaciones.Location = new Point(435, 232);
            ltbObservaciones.Name = "ltbObservaciones";
            ltbObservaciones.Size = new Size(176, 109);
            ltbObservaciones.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(72, 342);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 28;
            label13.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxEstado.Location = new Point(138, 339);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 27;
            cbxEstado.Text = "elige";
            // 
            // txtAnio_Academico
            // 
            txtAnio_Academico.Location = new Point(138, 114);
            txtAnio_Academico.MaxLength = 6;
            txtAnio_Academico.Name = "txtAnio_Academico";
            txtAnio_Academico.Size = new Size(100, 23);
            txtAnio_Academico.TabIndex = 29;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(435, 130);
            mtbTelefono.Mask = "0000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(148, 23);
            mtbTelefono.TabIndex = 30;
            // 
            // frmInscribirEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 444);
            Controls.Add(mtbTelefono);
            Controls.Add(txtAnio_Academico);
            Controls.Add(label13);
            Controls.Add(cbxEstado);
            Controls.Add(ltbObservaciones);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cbxCiclo);
            Controls.Add(btnInscribir);
            Controls.Add(label9);
            Controls.Add(cbxGenero);
            Controls.Add(label8);
            Controls.Add(txtDireccion);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtNie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxCarrera);
            Controls.Add(btnRegresar);
            Name = "frmInscribirEst";
            Text = " Inscribir Estudiantes";
            Load += frmInscribirEst_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnInscribir;
        private ComboBox cbxCarrera;
        private Label label1;
        private Label label2;
        private TextBox txtNie;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtApellidos;
        private DateTimePicker dtpNacimiento;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtDireccion;
        private Label label8;
        private ComboBox cbxGenero;
        private Label label9;
        private ComboBox cbxCiclo;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox ltbObservaciones;
        private Label label13;
        private ComboBox cbxEstado;
        private TextBox txtAnio_Academico;
        private MaskedTextBox mtbTelefono;
    }
}