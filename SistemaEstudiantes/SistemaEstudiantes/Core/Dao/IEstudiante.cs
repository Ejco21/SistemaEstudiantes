using SistemaEstudiantes.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal interface IEstudiante
    {
        int Insert(Estudiante paEstudiante);
        bool Update(Estudiante paEstudiante); 
        bool Delete(int paEstudiante);
        Estudiante GetById(int paEstudiante);
        List<Estudiante> GetAll(string filtro = "");
    }
}
