using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class Hotel
    {
        private string direccion;
        private string nombre;
        
        
        public Hotel(string direccion,  string nombre)
        {
            this.direccion = direccion; 
            this.nombre = nombre;
        }

        public string getDireccion() { return direccion; }
        public string getNombre() {  return nombre; }

        public void setDireccion(string direccion)
        {
            this.direccion=direccion;
        }
        public void setNombre(string nombre) { this.nombre=nombre; }    
    }
}
