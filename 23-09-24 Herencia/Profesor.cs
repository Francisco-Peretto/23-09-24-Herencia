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

        public string Materia { get { return this._Materia; } set { this._Materia = value; } }

        public Profesor(int pId, string pNombre, string pApellido, string pMateria) : base(pId, pNombre, pApellido) 
        {
            this.Materia = pMateria;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($" Materia: {this.Materia}");
        }
    }
}
