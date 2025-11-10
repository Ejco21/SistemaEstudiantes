using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Clases
{
    internal class Carrera
    {
        private int id_carrera;
        private string nombre_carrera;
        private int duracion_anios;
        private int total_ciclos;

        public int Id_carrera { get => id_carrera; set => id_carrera = value; }
        public string Nombre_carrera { get => nombre_carrera; set => nombre_carrera = value; }
        public int Duracion_anios { get => duracion_anios; set => duracion_anios = value; }
        public int Total_ciclos { get => total_ciclos; set => total_ciclos = value; }
    }
}
