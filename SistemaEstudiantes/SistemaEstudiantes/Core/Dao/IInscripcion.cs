using SistemaEstudiantes.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal interface IInscripcion
    {
        int Insert(Clases.Inscripcion paInscripcion);
        bool Update(Clases.Inscripcion paInscripcion);
        bool Delete(int paInscripcion);
        Clases.Inscripcion GetById(int paInscripcion);

    }
}
