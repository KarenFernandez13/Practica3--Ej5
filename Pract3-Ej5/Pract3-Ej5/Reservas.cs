using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<Habitaciones> ListaHabitaciones;
        private Clientes cliente;
        private string estado;
        
        public Reservas(int numeroReserva, DateTime fechaIngreso, DateTime fechaSalida, int cantDias, Clientes cliente, List<Habitaciones> ListaHabitaciones, string estado) 
        {
            this.numeroReserva = numeroReserva;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = fechaSalida;
            this.cantDias = cantDias;
            this.cliente = cliente;
            this.ListaHabitaciones = ListaHabitaciones;
            this.estado = estado;
        }

        public int getNumeroReserva() {  return numeroReserva; }
        public DateTime getFechaIngreso() {  return fechaIngreso; }
        public DateTime getFechaSalida() {  return fechaSalida; }
        public int getCantDias() {  return cantDias; }
        public Clientes getCliente() { return cliente; }
        public List<Habitaciones>GetHabitaciones() { return ListaHabitaciones; }   
        public string getEstado() { return estado; }

        public void setNumeroReserva(int numeroReserva) { this.numeroReserva=numeroReserva; }
        public void setFechaIngreso(DateTime fechaIngreso) { this.fechaIngreso=fechaIngreso; }
        public void setFechaSalida(DateTime fechaSalida) { this.fechaSalida=fechaSalida; }
        public void setClientes(Clientes cliente) { this.cliente = cliente; }   
        public void setHabitaciones(List<Habitaciones> ListaHabitaciones) { this.ListaHabitaciones = ListaHabitaciones; }
        public void setEstado(string estado) { this.estado = estado; }

        private List<Reservas>ListaReservas=new List<Reservas>();

        public List<Reservas>BuscarReservasPendientes(int documento)
        {
            List<Reservas>ReservasPendientes=new List<Reservas>();
            
            foreach (var item in ListaReservas)
            {
                if((item.cliente.getDocumento() == documento) && (estado == "Pendiente") )
                {
                    ReservasPendientes.Add(item);
                }
            }
            return ReservasPendientes;
        }
        public string CantidadDiasReservados()
        {
            var diasReservados = (getFechaSalida() - getFechaIngreso()).Days.ToString();
            return diasReservados;
        }
        private int contador;
        
        public bool MultiplesHabitaciones()
        {
            
            foreach (var x in ListaHabitaciones)
            {
                contador++;
            }
            if (contador > 1)
            {
                return true;
            }
            else { return false; }
        }

        //public double CostoTotalReserva(List<Habitaciones>listaHabitaciones)
        //{
        //    foreach (var h in listaHabitaciones)
        //    {
                
                
        //    }

        //}
    }
}
