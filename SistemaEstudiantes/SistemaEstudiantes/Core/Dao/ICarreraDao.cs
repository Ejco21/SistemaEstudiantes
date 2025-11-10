using SistemaEstudiantes.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal interface ICarreraDao
    {
        int Insert(Carrera paCarrera);
        bool Update(Carrera paCarrera);
        bool Delete(int id_carrera);

        Carrera GetById(int id_carrera);
        List<Carrera> GetAll(string filtro = "");

        
    }
}
