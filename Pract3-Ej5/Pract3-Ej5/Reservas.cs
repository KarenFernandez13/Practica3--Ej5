using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class Reservas
    {
        private int numeroReserva;
        private DateTime fechaIngreso;
        private DateTime fechaSalida;
        private int cantDias;
        private List<Habitaciones> habitacion;
        private Clientes cliente;
        
        public Reservas(int numeroReserva, DateTime fechaIngreso, DateTime fechaSalida, int cantDias, Clientes cliente, List<Habitaciones> habitacion) 
        {
            this.numeroReserva = numeroReserva;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.cantDias = cantDias;
            this.cliente = cliente;
            this.habitacion = habitacion;
        }


    }
}
