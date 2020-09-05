using System;

namespace Cusos
{
    public abstract class Persona
    {
        private int _id;
        private string _nombre;
        private int _dni;

        public Persona(){}

        public Persona(int id, string nombre, int dni) {
            this._id = id;
            this._nombre = nombre;
            this._dni = dni;
        }
        
        public int getId() {
            return this._id;
        }

        public string getNombre() {
            return this._nombre;
        }

        public int getDni() {
            return this._dni;
        }

    }
}
