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

        public static List<Consulta> ObtenerTodasLasConsutlas()
        {
            try
            {
                List<Consulta> consultas = new List<Consulta>();
                using (SqlConnection connection = new SqlConnection(GestorSQL.stringConnection))
                {
                    string query = "SELECT * FROM Pacientes;";
                    SqlCommand command = new SqlCommand(query, connection);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Consulta p = new Consulta();
                            p.Id = reader.GetInt32(0);
                            p.Descripcion = reader.GetString(1);
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
        public static bool EditarPaciente(Consulta consulta,int id)
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
