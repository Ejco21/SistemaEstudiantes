using Microsoft.Data.SqlClient;
using SistemaEstudiantes.Core.Clases;
using SistemaEstudiantes.Core.Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal class InscripcionViewDao : Cnn, IInscripcionViewDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;

        public List<InscripcionView> GetAll(string filtro = "")
        {
            
            var lista = new List<Clases.InscripcionView>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"
                            SELECT 
                                i.id_inscripcion,
                                e.nombres,
                                e.apellidos,
                                i.anio_academico,
                                c.nombre_ciclo
                            FROM Inscripcion i
                            INNER JOIN Estudiante e ON i.id_estudiante = e.id_estudiante
                            INNER JOIN Ciclo c ON i.id_ciclo = c.id_ciclo
                            /** where**/
                            ORDER BY i.id_inscripcion DESC;";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/** where**/", "WHERE id_inscripcion LIKE   OR id_estudiante LIKE @f OR id_ciclo LIKE @f OR anio_academico LIKE @f");
                }
                else
                {
                    sql = sql.Replace("/** where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 120).Value = $"%{filtro}%";
                }

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    lista.Add(new Clases.InscripcionView
                    {
                        Id_inscripcion = rd.GetInt32(0),
                        Nombres = rd.GetString(1),
                        Apellidos = rd.GetString(2),
                        Anio_academico = rd.IsDBNull(3) ? (short?)null : rd.GetInt16(3),
                        Nombre_ciclo = rd.GetString(4)
                    });
                }
            }

            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }

            return lista;
        }


        public InscripcionView GetById(int paInscripcion)
        {
            throw new NotImplementedException();
        }


    }
}
