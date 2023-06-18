using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Agus", 1133204587, "calle falsa 123", "email@email.com", true);
            Console.WriteLine(cliente);
        }

        public struct Cliente
        {
            public Cliente(string nombre, int telefono, string direccion, string email, bool newClient)
            {
                nombreCliente = nombre;
                telefonoCliente = telefono;
                direccionCliente = direccion;
                emailCliente = email;
                nuevoCliente = newClient;
            }

            public string nombreCliente { get; set; }
            public int telefonoCliente { get; set; }
            public string direccionCliente { get; set; }
            public string emailCliente { get; set; }
            public bool nuevoCliente { get; set; }

            public override string ToString() => $"{nombreCliente}, {telefonoCliente}, {direccionCliente}, {emailCliente} {nuevoCliente}";
        }

    }

}
