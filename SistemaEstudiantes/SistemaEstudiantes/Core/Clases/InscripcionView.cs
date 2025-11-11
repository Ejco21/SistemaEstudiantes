using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Clases
{
    internal class InscripcionView
    {
        private int id_inscripcion;
        private string nombres;
        private string apellidos;
        private short? anio_academico;
        private string nombre_ciclo;

        public int Id_inscripcion { get => id_inscripcion; set => id_inscripcion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public short? Anio_academico { get => anio_academico; set => anio_academico = value; }
        public string Nombre_ciclo { get => nombre_ciclo; set => nombre_ciclo = value; }
    }
}
