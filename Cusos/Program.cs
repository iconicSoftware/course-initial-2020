using System;

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

        }
    }
}
