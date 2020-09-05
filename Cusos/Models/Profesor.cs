using System;
using System.Collections.Generic;

namespace Cusos
{
    public class Profesor : Persona
    {
        private List<Alumno> _alumnos;
        private Curso _curso;

        public Profesor(int id, string nombre, int dni, Curso curso) : base(id, nombre, dni) {
            this._alumnos = new List<Alumno>();
            this._curso = curso;
        }

        public void addAlumno(Alumno alumno) {
            this._alumnos.Add(alumno);
        }

        public List<Alumno> getAlumnos() {
            return this._alumnos;
        }

        public Curso getCurso() {
          return this._curso;  
        } 

    }
}