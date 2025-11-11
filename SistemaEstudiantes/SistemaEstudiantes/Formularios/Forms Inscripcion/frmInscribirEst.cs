using SistemaEstudiantes.Core.Dao;
using SistemaEstudiantes.Core.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SistemaEstudiantes.Formularios.Forms_Inscripcion
{
    public partial class frmInscribirEst : Form
    {
        public frmInscribirEst()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInscripcion frmInscripcion = new frmInscripcion();
            this.Hide();
            frmInscripcion.Show();
        }

        private void frmInscribirEst_Load(object sender, EventArgs e)
        {
            cbxCarrera.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int idPensum;

            if (cbxCarrera.SelectedItem.ToString() == "Desarrollo de Software")
            {
                idPensum = 1;
            }
            else if (cbxCarrera.SelectedItem.ToString() == "Gastronomía")
            {
                idPensum = 2;
            }
            else
            {
                MessageBox.Show("Selecciona una carrera válida.");
                return;
            }



            EstudianteDao estudianteDao = new EstudianteDao();
            Estudiante estudiante = new Estudiante()
            {
                id_pensum = idPensum,
                Nie = txtNie.Text.Trim(),
                Nombres = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Fecha_nacimiento = dtpNacimiento.Value,
                Email = txtEmail.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = mtbTelefono.Text.Trim(),
                Genero = cbxGenero.Text.Trim(),
                Estado = cbxEstado.Text.Trim(),
                Fecha_registro = dtpNacimiento.Value
            };

            int id = 1000;

            try
            {
                id = estudianteDao.Insert(estudiante);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado" + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            int idciclo;
            if (cbxCiclo.SelectedItem.ToString() == "1")
            {
                idciclo = 1;
            }
            else if (cbxCiclo.SelectedItem.ToString() == "2")
            {
                idciclo = 2;
            }
            else
            {
                MessageBox.Show("Selecciona un ciclo válido.");
                return;
            }

            short? anioAcademico = null;
            if (short.TryParse(txtAnio_Academico.Text.Trim(), out short resultado))
            {
                anioAcademico = resultado;
            }


            InscripcionDao inscripcionDao = new InscripcionDao();
            Inscripcion inscripcion = new Inscripcion()
            {
                Id_estudiante = id,
                Id_ciclo = idciclo,
                Anio_academico = anioAcademico,
                Observaciones = ltbObservaciones.Text
            };

            try
            {
                inscripcionDao.Insert(inscripcion);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado" + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (id > 0)
            {
                MessageBox.Show("Estudiante inscrito con exito",
                    "Exito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                frmInscripcion frmInscripcion = new frmInscripcion();
                this.Close();
                frmInscripcion.Show();
            }
            else
            {
                MessageBox.Show("Estudiante ingresado sin exito",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
