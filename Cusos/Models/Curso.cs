using System;

namespace Cusos
{
    public class Curso
    {
        private int _id;
        private string _nombre;

        public Curso(){}

        public Curso(int id, string nombre) {
            this._id = id;
            this._nombre = nombre;
        }
        
        public int getId() {
            return this._id;
        }

        public string getNombre() {
            return this._nombre;
        }
    }
}