// librerias o dependencias
using System;
using System.Collections;
using System.Collections.Generic;

// nombre de espacio o paquete
namespace Desktop
{

    // nombre de la clase
    class Program
    {
        // metodo de arranque de nuestro sistema
        static void Main(string[] args)
        {
            // constantes
            // const string nombre = "Agustin Decima"; 
            // declaracion de variables
            // int numero = 3;
            // decimal flotante = 5.5M;
            // bool verdadero = true;
            // String cadena = "Hola Mundo";
            // char caracter = '1';
        
            // for (int i = 0; i < 5; i++)
            // {}

            // while (true)
            // {}

            // do
            // {} while (true);

            // // arreglos
            // string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            // for (int i = 0; i < cars.Length; i++)
            // {
            //     Console.WriteLine(cars[i]);
            // }

            Personaje mario = new Personaje(); // instancio mi objeto Personaje
            mario.nombre = "Mario"; // asignacion de valor
            mario.fuerza = 5;
            mario.salud = 10;
            mario.velocidad = 3;

            // Personaje luigi = new Personaje(); // instancio mi objeto Personaje
            // luigi.nombre = "Luigi"; // asignacion de valor
            // luigi.fuerza = 3;
            // luigi.salud = 15;
            // luigi.velocidad = 5;

            // Personaje wario = new Personaje("Wario",5,8,10);

            // Console.WriteLine(mario.detallePersonaje());
            // Console.WriteLine(mario.esCapaz(5));
            // Console.WriteLine(wario.detallePersonaje());

            // List<int> nuevo = new List<int>();
            // nuevo.Add(2);
            // nuevo.Add(3);
            // nuevo.Add(10);

            Estudiante agustin = new Estudiante("agustin", "decima", "programacion");
            Estudiante luciano = new Estudiante("agustin", "decima", "programacion");
            Empleado otro = new Empleado("pepe","saenz",50000.0);
            Empleado javier = new Empleado("pepe","saenz",50000.0);

            Persona[] persona = {agustin, luciano, otro, javier}; 

            // polimorfismo por herencia
            Chihuahua uno = new Chihuahua();
            Chihuahua dos = new Chihuahua();
            Bulldog tres = new Bulldog();
            Bulldog cuatro = new Bulldog();

            Perro[] _perros = {uno, dos, tres, cuatro};

            // polimorfismo por abstraccion
            ChihuahuaAbs unoa = new ChihuahuaAbs();
            ChihuahuaAbs dosa = new ChihuahuaAbs();
            BulldogAbs tresa = new BulldogAbs();
            BulldogAbs cuatroa = new BulldogAbs();

            PerroAbs[] _perrosAbs = {unoa, dosa, tresa, cuatroa};

            // for (int i = 0; i < _perros.Length; i++)
            // {
            //     _perros[i].ladrar();
            // }

            foreach (var perro in _perrosAbs)
            {
                Console.WriteLine(perro.ladrar());   
            }
            

        }
    }
}