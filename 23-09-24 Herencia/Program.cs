using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_09_24_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Poo pilares: Abstracción, Encapsulamiento, Herencia (hoy), Polimorfismo
            int opcion;
            string nombre, apellido, materia;
            int id;
            bool salir = false;
            List<Profesor> listaProfesores;
            List<Personal> listaPersonales;

            listaProfesores = new List<Profesor>();
            listaPersonales = new List<Personal>();

            /*
            Personal _Personal = new Personal();
            _Personal.Id = 1;
            _Personal.Nombre = "Pepe";
            _Personal.Apellido = "Quer";

            Profesor _profesor = new Profesor(1, "Diego", "Mendoza", "Programación II");

            Console.WriteLine("Clase Profesor");
            Console.WriteLine("ID: {0}, Nombre: {1}, Apellido: {2}, Materia {3}", _profesor.Id, _profesor.Nombre, _profesor.Apellido, _profesor.Materia);

            Console.WriteLine("\nClase Personal");
            Console.WriteLine("ID: {0}, Nombre: {1}, Apellido: {2}", _Personal.Id, _Personal.Nombre, _Personal.Apellido);
            */

            do
            {
                Console.Write("Ingrese 1 para cargar un profesor, 2 para cargar un personal, 3 para salir: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: // Profesor
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        nombre = (Console.ReadLine());
                        Console.Write("Apellido: ");
                        apellido = (Console.ReadLine());
                        Console.Write("Materia: ");
                        materia = (Console.ReadLine());
                        Profesor profesor = new Profesor(id, nombre, apellido, materia);
                        listaProfesores.Add(profesor);
                        break;

                    case 1:
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        nombre = (Console.ReadLine());
                        Console.Write("Apellido: ");
                        apellido = (Console.ReadLine());
                        Personal personal = new Personal(id, nombre, apellido);
                        listaPersonales.Add(personal);
                        break;
                    case 2:
                        Console.WriteLine("Saliendo");
                        
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.ReadKey();

            }
            while (!salir);
        }
    }
}
