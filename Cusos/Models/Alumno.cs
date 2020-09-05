using System;

namespace Cusos
{
    public class Alumno : Persona
    {

        private int _nota;
        public Alumno(int id, string nombre, int dni, int nota) : base(id,nombre, dni) {
            this._nota = nota;
        }

        public int getNota() {
            return this._nota;
        }

    }
}