using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_09_24_Herencia
{
    internal class Personal
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;

        public Personal(int pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }

        public int Id { get { return this._Id; } set { this._Id = value; } }

        public string Nombre {  get { return this._Nombre; } set { this._Nombre = value; } }

        public string Apellido { get { return this._Apellido; } set { this._Apellido = value; } }

        public virtual void MostrarDatos()
        {
            Console.Write($"Id: {this.Id} - Nombre: {this.Nombre} - Apellido: {this.Apellido}");
        }
    }
}
