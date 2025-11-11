using Microsoft.Data.SqlClient;
using SistemaEstudiantes.Core.Clases;
using SistemaEstudiantes.Core.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaEstudiantes.Core.Dao
{
    internal class InscripcionDao : Cnn, IInscripcion
    {
        SqlConnection Con = null;
        SqlCommand command = null; 
        public bool Delete(int paIdInscripcion)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Inscripcion 
                                WHERE id_inscripcion = @Id;", Con);

                command.Parameters.Add("@Id", SqlDbType.Int).Value = paIdInscripcion;

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


        public Clases.Inscripcion GetById(int paInscripcion)   
        {
            throw new NotImplementedException();
        }

        public int Insert(Clases.Inscripcion paInscripcion)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"INSERT INTO Inscripcion (id_estudiante,id_ciclo, anio_academico, estado, observaciones)
                            VALUES (@id_estudiante, @id_ciclo, @anio_academico, @estado, @observaciones);", Con);
                
                command.Parameters.Add("@id_estudiante", SqlDbType.Int, 100).Value = paInscripcion.Id_estudiante;

                command.Parameters.Add("@id_ciclo", SqlDbType.Int, 100).Value = paInscripcion.Id_ciclo;

                command.Parameters.Add("@estado", SqlDbType.VarChar, 20).Value = "Activo";

                command.Parameters.Add("@anio_academico", SqlDbType.SmallInt).Value =(object?)paInscripcion.Anio_academico ?? DBNull.Value;

                command.Parameters.Add("@observaciones", SqlDbType.VarChar, 255).Value =(object?) paInscripcion.Observaciones ?? DBNull.Value;

                var idGenerado = command.ExecuteScalar();

                return Convert.ToInt32(idGenerado);
            } 
            catch (Exception ex)
            {
                throw new ApplicationException("Hay datos que ya existen, verifica la informacion.", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }
        

        public bool Update(Clases.Inscripcion paInscripcion)
        {
            throw new NotImplementedException();
        }
    }
}
