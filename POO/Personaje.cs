using System;

namespace Desktop
{
    // public : lo pueden ver y acceder todas las clases
    // private: solo se puede acceder dentro de la clase
    public class Personaje
    {
        // atributos o propiedades
        public String nombre;
        public int velocidad;
        public int salud;
        public int fuerza;

        // constructor
        public Personaje(){}

        public Personaje(String nombre, int velocidad, int salud, int fuerza){
            this.nombre = nombre;
            this.velocidad = velocidad;
            this.salud = salud;
            this.fuerza = fuerza;
        }

        // declaracion de metodos
        public String detallePersonaje() {
            return "nombre: " + nombre + " vel: " + velocidad + " salud: " + salud + " fuerza: " + fuerza;
        }

        // determina si el personaje es capaz de vencer al enemigo
        public bool esCapaz(int fuerzaEnemigo) {
            if(fuerza > fuerzaEnemigo) {
                return true;
            }
            return false;
        }


    }
}
