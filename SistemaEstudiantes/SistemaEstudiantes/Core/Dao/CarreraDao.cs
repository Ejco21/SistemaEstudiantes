using Microsoft.Data.SqlClient;
using SistemaEstudiantes.Core.Clases;
using SistemaEstudiantes.Core.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal class CarreraDao : Cnn, ICarreraDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int id_carrera)
        {
            throw new NotImplementedException();
        }

        public List<Carrera> GetAll(string filtro = "")
        {
            var lista = new List<Carrera>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"
                              SELECT id_carrera, nombre_carrera, duracion_anios, total_ciclos
                              FROM Carrera /**where**/
                              ORDER BY id_carrera DESC;";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/**where**/", "WHERE nombre_carrera LIKE @f OR duracion_anios LIKE @f");

                }
                else
                {
                    sql = sql.Replace("/**where**/", string.Empty);
                }
                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                    command.Parameters.Add("@f", System.Data.SqlDbType.VarChar, 120).Value = $"%{filtro}%";

                rd = command.ExecuteReader();
                
                while (rd.Read())
                {
                    lista.Add(Map(rd));
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

        private static Carrera Map(SqlDataReader rd) => new Carrera
        {
            Id_carrera = rd.GetInt32(0),
            Nombre_carrera = rd.GetString(1),
            Duracion_anios = rd.GetInt32(2),
            Total_ciclos = rd.GetInt32(3),

        };


        public Carrera GetById(int id_carrera)
        {
            throw new NotImplementedException();
        }

        public int Insert(Carrera paCarrera)
        {
            throw new NotImplementedException();
        }

        public bool Update(Carrera paCarrera)
        {
            throw new NotImplementedException();
        }
    }
}
