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
            //List<Personal> listaPersonales;

            listaProfesores = new List<Profesor>();
            //listaPersonales = new List<Personal>();

            do
            {
                Console.Clear();
                Console.Write("1: cargar un profesor, 2: cargar un personal, 3: salir: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Profesor
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
                        Console.WriteLine("\nProfesor guardado.");
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        break;

                    case 2: // Personal
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        nombre = (Console.ReadLine());
                        Console.Write("Apellido: ");
                        apellido = (Console.ReadLine());
                        //Personal personal = new Personal(id, nombre, apellido);
                        //listaPersonales.Add(personal);
                        Console.WriteLine("\nPersonal guardado.");
                        Console.WriteLine("\nPresione una tecla para continuar.");
                        break;
                    case 3:
                        /*if (listaPersonales.Count > 0)
                        {
                            Console.WriteLine("\nLista del personal.");
                            foreach (Personal personal1 in listaPersonales)
                            {
                                personal1.MostrarDatos();
                            }
                        }    */

                        if (listaProfesores.Count > 0)
                        {
                            Console.WriteLine("\n\nLista de profesores.");
                            foreach (Personal profesor1 in listaProfesores)
                            {
                                profesor1.MostrarDatos();
                            }
                        }

                        Console.WriteLine("\nSaliendo. Presione una tecla para continuar.");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Error.");
                        break;
                }
                Console.ReadKey();
            }
            while (!salir);
        }
    }
}
