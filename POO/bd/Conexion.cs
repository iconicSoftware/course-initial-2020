using System;
using MySql;
using MySql.Data.MySqlClient;

namespace Desktop
{
    class Conexion
    {
        String connectionString = "Server=127.0.0.1;Port=3306;Database=facturacion;Uid=root;password=root1234;";

        public void ConectionToBD()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT NOW() as FECHA";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["FECHA"].ToString());
                    }
                }
                conexion.Dispose();
            }
        }

    }

}