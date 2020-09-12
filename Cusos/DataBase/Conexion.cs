using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Cusos
{
    public class Conexion {

        String connectionString = "Server=127.0.0.1;Port=3306;Database=cursos;Uid=root;password=root1234;";

        public Profesor getProfesoreById(int idProfesor)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT * FROM profesores WHERE id_profesor = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = idProfesor;
                Profesor profesor = new Profesor();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_profesor"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int dni = int.Parse(reader["dni"].ToString());

                        profesor.setId(id);
                        profesor.setNombre(nombre, apellido);
                        profesor.setDni(dni);
                        // Console.WriteLine(reader["id_profesor"].ToString());
                        // Console.WriteLine(reader["nombre"].ToString());
                        // Console.WriteLine(reader["apellido"].ToString());
                        // Console.WriteLine(reader["dni"].ToString());
                    }
                }
                conexion.Dispose();
                return profesor;
            }

        }

         public List<Profesor> getAllProfesore()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT * FROM profesores";
                List<Profesor> profesores = new List<Profesor>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Profesor profesor = new Profesor();
                        int id = int.Parse(reader["id_profesor"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int dni = int.Parse(reader["dni"].ToString());

                        profesor.setId(id);
                        profesor.setNombre(nombre, apellido);
                        profesor.setDni(dni);
                        

                        profesores.Add(profesor);
                    }
                }
                conexion.Dispose();
                return profesores;
            }

        }




    }
}