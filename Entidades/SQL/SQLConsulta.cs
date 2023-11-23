using Entidades.Clases;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class SQLConsulta
    {
        /// <summary>
        /// Devuelve un Objeto de tipo Consulta de una tabla sql
        /// </summary>
        /// <param name="id">id del objeto a devolver</param>
        /// <returns>objeto de tipo Consulta</returns>
        /// <exception cref="ErrorEnConcexionSQLException"></exception>
        public static Consulta ObtenerConsultaPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Consultas WHERE idConsulta= @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Consulta p = new Consulta();
                        p.Id = reader.GetInt32(0);
                        p.Descripcion = reader.GetString(1);
                        p.IdPaciente = reader.GetInt32(2);
                        p.IdPractica = reader.GetInt32(3);
                        return p;
                    }
                    else
                    {
                        throw new ErrorEnConcexionSQLException("No encontro Consulta");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error en la conexion a la Base de datos", ex);
            }
        }
        /// <summary>
        /// Devuelve una lista de tipo Consulta a partir de una tabla de una DB
        /// </summary>
        /// <returns>Lista de tipo Consulta</returns>
        /// <exception cref="ErrorEnConcexionSQLException"></exception>
        public static List<Consulta> ObtenerTodasLasConsutlas()
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Consultas;";
                    SqlCommand command = new SqlCommand(query, connection);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Consulta p = new Consulta();
                            p.Id = reader.GetInt32(0);
                            if(reader.GetString(1) is  not null)
                            {
                                p.Descripcion = reader.GetString(1);
                            }
                            else
                            {
                                p.Descripcion = string.Empty;
                            }
                            p.IdPaciente = reader.GetInt32(2);
                            p.IdPractica = reader.GetInt32(3);
                            
                            consultas.Add(p);
                        }
                    }
                    else
                    {
                        throw new ErrorEnConcexionSQLException("No encontro Paciente");
                    }

                }
                return consultas;
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error en la conexion a la Base de datos", ex);
            }
        }
        /// <summary>
        /// Añade una nueva consulta a la tabla sql
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns>true si pudo agregar la conuslta, si no arroja una excepción</returns>
        /// <exception cref="ErrorEnConcexionSQLException"></exception>
        public static bool AgregarConsulta(Consulta consulta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "INSERT INTO Consultas (descripcion, idPaciente, idPractica)" +
                        "values(@descripcion, @paciente, @practica)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("descripcion", consulta.Descripcion);
                    command.Parameters.AddWithValue("paciente", consulta.IdPaciente);
                    command.Parameters.AddWithValue("practica", consulta.IdPractica);
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo agregar", ex);
            }
        }
        public static bool BorrarConsulta(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "DELETE FROM Consultas WHERE idConsultas = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo borrar", ex);
            }
        }
        /// <summary>
        /// Edita el registro de una consulta en una tabla (Consultas) de una BD (TP2_2C_2023)
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ErrorEnConcexionSQLException"></exception>
        public static bool EditarConsulta(Consulta consulta,int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "UPDATE Consutlas set descrípcion= @descripcion, idPaciente = @IdPaciente, idPractica = @IdPractica WHERE idPaciente = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("descripcion", consulta.Descripcion);
                    command.Parameters.AddWithValue("paciente", consulta.IdPaciente);
                    command.Parameters.AddWithValue("practica", consulta.IdPractica);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEnConcexionSQLException("Error, no se pudo editar la persona", ex);
            }
        }
    }
}
