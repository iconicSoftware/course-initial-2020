using System;
using MySql;
using MySql.Data.MySqlClient;

namespace Desktop
{
    class Conexion
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=cursos;Uid=root;password=root1234;";

        public void ConectionToBD()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT * FROM profesores WHERE id_profesor = ?id";
                //cmd.CommandText = $"select * from Articulo where id = ?articuloId";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = 2;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["id_profesor"].ToString());
                        Console.WriteLine(reader["nombre"].ToString());
                        Console.WriteLine(reader["apellido"].ToString());
                        Console.WriteLine(reader["dni"].ToString());
                    }
                }
                conexion.Dispose();
            }
        }

        public void insertProfesor()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO `ejemplo-conexion`.`Articulo` (`Titulo`, `Contenido`, `AutorId`, `Fecha`) VALUES (?titulo, ?contenido, ?autorid, ?fecha);";

                cmd.Parameters.Add("?titulo", MySqlDbType.VarChar).Value = $"nuevo titulo";
                cmd.Parameters.Add("?contenido", MySqlDbType.VarChar).Value = $"nuevo contenido";
                cmd.Parameters.Add("?AutorId", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }
        }

        // cmd.ExecuteNonQuery();
        // var ultimoId = cmd.LastInsertedId;

        public void updateProfesor()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "update `ejemplo-conexion`.`Articulo` SET `Titulo` = ?titulo where ID = ?id;";

                cmd.Parameters.Add("?titulo", MySqlDbType.VarChar).Value = $"titulo actualizado";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = 3;

                cmd.ExecuteNonQuery();
            }
        }
    }

}