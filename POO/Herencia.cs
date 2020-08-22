using System;

namespace Desktop
{
    public class Persona
    {
        public string nombre;
        public string apellido;


        public Persona(string nombre, string apellido){
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }

    public class Estudiante : Persona {

        public string curso;

        public Estudiante(string nombre, string apellido, string curso) 
        : base(nombre, apellido) {
            this.curso = curso;
        }

    }

    public class Empleado : Persona {
        public double sueldo;

        public Empleado(string nombre, string apellido, double sueldo)
        : base(nombre, apellido) {
            this.sueldo = sueldo;
        }


    }
    
}
