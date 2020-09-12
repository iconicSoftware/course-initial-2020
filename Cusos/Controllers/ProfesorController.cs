using System;

namespace Cusos
{
    public static class ProfesorController
    {
        public static bool findAllProfesor() {
            
            return true;

        }

        public static Profesor findProfesorById(int id) {
            Conexion cn = new Conexion();

            if(id == 0) {
                throw new Exception();
            }

            Profesor profesor = cn.getProfesoreById(id);
            return profesor;
        }
        public static bool saveProfesor(Profesor profesor) {
            
            if(profesor.getNombre().Length == 0 && profesor.getId() == 0) {
                throw new Exception("Los datos estna vacios");
            }

            return true;

        }

        public static bool updateProfesor(Profesor profesor) {
            
            return true;

        }

        public static bool deleteProfesor(Profesor profesor) {
            
            return true;

        }

    }
}
