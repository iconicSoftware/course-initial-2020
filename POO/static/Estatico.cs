using System;

namespace Desktop
{
    public static class Estatico
    {
        public static string saluda(string nombre) {
            string palabra = "Hola, como estas ? " + nombre; 
            return palabra;
        }

        public static int edad(int anioNacimiento) {
            int edadFinal = 2020 - anioNacimiento;
            return edadFinal;
        }

        public static string palabra(string palabra) {
            return palabra;
        }

    }
}