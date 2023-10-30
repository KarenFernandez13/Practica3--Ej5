using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class Clientes
    {
        private int documento;
        private string nombre;
        private string apellido;
        private int telefono;
        private string direccion;
        private bool premium;

        public Clientes(int documento, string nombre, string apellido, int telefono, string direccion, bool premium)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.premium = premium;
        }

        public int getDocumento() { return documento; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public int getTelefono() { return telefono; }
        public string getDireccion() { return direccion; }
        public bool getPremium() { return premium; }

        public void setPremium(bool premium) { this.premium = premium; }
        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setTelefono(int telefono) { this.telefono = telefono; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDocumento(int documento) { this.documento = documento; }


    }
}
