using System;
using System.Collections;
using System.Collections.Generic;

namespace Desktop
{
    public class Empresa
    {
        public int cuit;
        public string nombre;
        public string direccion;
        private List<Cliente> clientes;
        private List<EmpleadoAyC> empleados;

        public Empresa() {
            clientes = new List<Cliente>();
            empleados = new List<EmpleadoAyC>();
        }

        public void addCliente(Cliente cliente) {
            clientes.Add(cliente);
        }

        public List<Cliente> getClientes() {
            return clientes;
        }

         public void addEmpleado(string nombre, string apellido, double sueldo) {
             // creamos empleado
             EmpleadoAyC e1 = new EmpleadoAyC();
             e1.nombre = nombre;
             e1.apellido = apellido;
             e1.sueldo = sueldo;

            empleados.Add(e1);
        }

        public List<EmpleadoAyC> getEmpleados() {
            return empleados;
        }


    }
}