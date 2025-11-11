using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Clases
{
    internal class Inscripcion
    {
        private int id_inscripcion;
        private int id_estudiante;
        private int id_ciclo;
        private short? anio_academico;
        private string estado;
        private string observaciones;

        public int Id_inscripcion { get => id_inscripcion; set => id_inscripcion = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public int Id_ciclo { get => id_ciclo; set => id_ciclo = value; }
        public short? Anio_academico { get => anio_academico; set => anio_academico = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
