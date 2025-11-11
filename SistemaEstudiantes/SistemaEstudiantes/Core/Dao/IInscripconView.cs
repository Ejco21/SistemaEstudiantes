using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal interface IInscripcionView
    {
        int insert(Clases.InscripcionView paInscripcion);
        bool Update(Clases.InscripcionView paInscripcion);
        bool Delete(Clases.InscripcionView paInscripcion);
        Clases.InscripcionView GetById(int paInscripcion);
        List<Clases.InscripcionView> GetAll(string filtro = "");
    }
}
