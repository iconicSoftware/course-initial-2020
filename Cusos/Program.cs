using System;
using System.Collections.Generic;

namespace Cusos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos cursos
            Curso c1 = new Curso(1, "Algoritmos");
            Curso c2 = new Curso(2, "Analisis");

            // Creamos alumnos
            Alumno javier = new Alumno(1,"Javier Barboza",30344833,0);
            Alumno luciano = new Alumno(2,"Luciano Cortes", 38111222, 0);

            // Creamos profesores
            Profesor pepe = new Profesor(1,"Pepe Saenz",11122233,c1);
            Profesor agustin = new Profesor(2,"Agustin Decima",38652010,c2);

            // asignamos alumnos a profesor
            pepe.addAlumno(javier);
            pepe.addAlumno(luciano);
            
            // creamos arreglo de personas
            Persona[] personas = {javier, luciano, pepe, agustin};

            Conexion cn = new Conexion();
            Profesor p1 = ProfesorController.findProfesorById(1);

            Console.WriteLine("---- get profesor by id -----");
            Console.WriteLine(p1.getId());
            Console.WriteLine(p1.getNombre());
            Console.WriteLine(p1.getDni());
            Console.WriteLine("------------------");

            List<Profesor> profesores = cn.getAllProfesore();
            
            Console.WriteLine("---- get all profesores ----");
            foreach (var profesor in profesores)
            {
                Console.WriteLine(profesor.getId());
                Console.WriteLine(profesor.getNombre());
                Console.WriteLine(profesor.getDni());
            }

            // for (int i = 0; i < profesores.Count; i++)
            // {
            //     Console.WriteLine(profesores[i].getId());
            //     Console.WriteLine(profesores[i].getNombre());
            //     Console.WriteLine(profesores[i].getDni());
            // }

            Profesor p3 = new Profesor();
            p3.setNombre("asdads","aasd");
            p3.setId(2);
            ProfesorController.saveProfesor(p3);


        }
    }
}
