using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_09_24_Herencia
{
    internal class Profesor : Personal
    {
        private string _Materia;

        public string Materia
        {
            get { return this._Materia; }
            set { this._Materia = value; }
        }

        public Profesor(int pId, string pNombre, string pApellido, string pMateria)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Materia = pMateria;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Id: {this.Id} - Nombre: {this.Nombre} - Apellido: {this.Apellido} - Materia: {this.Materia}");
        }
    }
}
