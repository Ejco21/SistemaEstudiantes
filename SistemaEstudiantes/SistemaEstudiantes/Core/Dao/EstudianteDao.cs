using Microsoft.Data.SqlClient;
using SistemaEstudiantes.Core.Clases;
using SistemaEstudiantes.Core.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantes.Core.Dao
{
    internal class EstudianteDao : Cnn, IEstudiante
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int paIdEstudiante)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Inscripcion 
                                WHERE id_estudiante = @Id;", Con);

                command.Parameters.Add("@Id", SqlDbType.Int).Value = paIdEstudiante;

                return command.ExecuteNonQuery() == 1;

            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ApplicationException("No se puede eliminar la inscripcion"
                    + ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public List<Estudiante> GetAll(string filtro = "")
        {
            throw new NotImplementedException();
        }

        public Estudiante GetById(int paEstudiante)
        {
            throw new NotImplementedException();
        }

        public int Insert(Estudiante paEstudiante)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"INSERT INTO Estudiante (id_pensum,nie, nombres, apellidos, fecha_nacimiento , email, direccion, telefono, genero,estado, fecha_registro)
                            OUTPUT INSERTED.id_estudiante
                            VALUES (@id_pensum, @nie, @nombres, @apellidos, @fecha_nacimiento, @email, @direccion, @telefono, @genero,@estado, @fecha_registro);", Con);
                command.Parameters.Add("@id_pensum", SqlDbType.Int, 100).Value = paEstudiante.id_pensum;
                command.Parameters.Add("@nie", SqlDbType.VarChar, 20).Value = paEstudiante.Nie;
                command.Parameters.Add("@nombres", SqlDbType.VarChar, 100).Value = paEstudiante.Nombres;
                command.Parameters.Add("@apellidos", SqlDbType.VarChar, 100).Value = paEstudiante.Apellidos;
                command.Parameters.Add("@estado", SqlDbType.VarChar, 20).Value = paEstudiante.Estado;

                command.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = (object?)paEstudiante.Fecha_nacimiento ?? DBNull.Value;

                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = (object?)paEstudiante.Email ?? DBNull.Value;

                command.Parameters.Add("@direccion", SqlDbType.VarChar, 150).Value = (object?)paEstudiante.Direccion ?? DBNull.Value;
                 
                command.Parameters.Add("@telefono", SqlDbType.VarChar, 20).Value = (object?)paEstudiante.Telefono ?? DBNull.Value;

                command.Parameters.Add("@genero", SqlDbType.VarChar, 10).Value = (object?)paEstudiante.Genero ?? DBNull.Value;

                command.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = (object?)paEstudiante.Fecha_registro ?? DBNull.Value;

                var id = command.ExecuteScalar();

                return Convert.ToInt32(id);
            }
            catch (SqlException ex) when (ex.Number == 2627 ||  ex.Number == 2601)
            {
                throw new ApplicationException("Hay datos que ya existen, verifica la informacion.", ex); 
            }
            finally 
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public bool Update(Estudiante paEstudiante)
        {
            throw new NotImplementedException();
        }
    }
}
