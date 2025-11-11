using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Clases
{
    internal class Estudiante
    {
        private int Id_estudiante;
        private int Id_pensum;
        private string nie;
        private string nombres;
        private string apellidos;
        private DateTime? fecha_nacimiento;
        private string email;
        private string direccion;
        private string telefono;
        private string genero;
        private string estado;
        private string observaciones;
        private DateTime? fecha_registro;

        public int id_estudiante { get => Id_estudiante; set => Id_estudiante = value; }
        public int id_pensum { get => Id_pensum; set => Id_pensum = value; }
        public string Nie { get => nie; set => nie = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime? Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Email { get => email; set => email = value; }  
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime? Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
    }
}
