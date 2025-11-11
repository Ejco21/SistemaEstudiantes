using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal interface IInscripcionViewDao
    {
        Clases.InscripcionView GetById(int paInscripcion);
        List<Clases.InscripcionView> GetAll(string filtro = "");
    }
}
