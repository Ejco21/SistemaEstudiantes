using SistemaEstudiantes.Core.Clases;
using SistemaEstudiantes.Core.Dao;
using SistemaEstudiantes.Core.Lib;
using SistemaEstudiantes.Formularios.Forms_Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiantes
{
    public partial class frmInscripcion : Form
    {

        private InscripcionDao inscripcionDao = new InscripcionDao();

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void ConfiguracionGrid()
        {
            dgvInscripcion.AutoGenerateColumns = false;
            dgvInscripcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripcion.MultiSelect = false;
            dgvInscripcion.Columns.Clear();


            dgvInscripcion.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreCol", HeaderText = "Nombre", DataPropertyName = "Nombres", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvInscripcion.Columns.Add(new DataGridViewTextBoxColumn { Name = "ApellidosCol", HeaderText = "Apellidos", DataPropertyName = "Apellidos", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvInscripcion.Columns.Add(new DataGridViewTextBoxColumn { Name = "AnioAcademicoCol", HeaderText = "Año Académico", DataPropertyName = "Anio_academico", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvInscripcion.Columns.Add(new DataGridViewTextBoxColumn { Name = "CicloCol", HeaderText = "Ciclo", DataPropertyName = "Nombre_ciclo", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }
        private readonly InscripcionViewDao inscripcionViewDao = new InscripcionViewDao();
        private void Cargar(string filtro = "")
        {

            dgvInscripcion.DataSource = inscripcionViewDao.GetAll(filtro);
            dgvInscripcion.ClearSelection();

            dgvInscripcion.CurrentCell = null;

        }
        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            ConfiguracionGrid();
            Cargar();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirEst frmInscribirEst = new frmInscribirEst();

            this.Hide();
            frmInscribirEst.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.Show();
        }

        private int? GetIdSeleccionado()
        {
            if (dgvInscripcion.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una inscripción.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            if (dgvInscripcion.CurrentRow.DataBoundItem is InscripcionView painscripcionview)
                return painscripcionview.Id_inscripcion;

            return null;    
        } 


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();

            if (!id .HasValue)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            else
            {
                MessageBox.Show("Eliminar" + id.Value);
            }

            var respuesta = MessageBox.Show("¿Desea eliminar la inscripcion Seleccionada?",
                "Confimar eliminaciónn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No) return;

            EstudianteDao estudianteDao = new EstudianteDao();

            try
            {
                if (inscripcionDao.Delete(id.Value))
                {
                    Cargar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la inscripcion.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (ApplicationException ex)
            {
                MessageBox.Show("No se puedo eliminar la inscripcion" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Error inesperado: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
