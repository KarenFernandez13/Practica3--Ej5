using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class Habitaciones
    {
        
        private int numeroHab;
        private int Piso;
        private string descripcion;
        TipoHabitacion Tipo;

        public Habitaciones(int numeroHab, int Piso, string descripcion, int codigoTipo, string nombreTipo, double costoNoche)
        {
            this.numeroHab = numeroHab;
            this.Piso = Piso;
            this.descripcion = descripcion;
            this.Tipo = new TipoHabitacion(codigoTipo,nombreTipo, costoNoche);
        }
        public int getNumeroHab() {  return numeroHab; }
        public int getPiso() {  return Piso; }
        public string getDescripcion() { return descripcion; }
        public TipoHabitacion getTipo() { return Tipo; }

        public void setNumeroHab(int numeroHab) { this.numeroHab=numeroHab; }
        public void setPiso(int piso) { this.Piso=piso; }
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public void setTipoHabitacion(TipoHabitacion Tipo) { this.Tipo=Tipo; }
    }
}
