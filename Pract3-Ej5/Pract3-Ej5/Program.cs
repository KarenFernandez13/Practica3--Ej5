using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaEspecifica = new DateTime(2024, 03, 20);
            Hotel Hotel1 = new Hotel("25 de Mayo", "Maldonado");    
            Habitaciones habitacion101 = new Habitaciones(101, 1, "simple", 1, "simple", 100);
            Habitaciones habitacion201 = new Habitaciones(201, 2, "Habitacion doble", 2, "Doble", 150);
            
            Clientes cliente1 = new Clientes(2323233, "Juansito", "Perez", 098556373, "Sarandí", true);
            List<Clientes>misClientes = new List<Clientes>();
            misClientes.Add(cliente1);
            
            List<Habitaciones>HabDeReserva1= new List<Habitaciones>();
            HabDeReserva1.Add(habitacion101);
            HabDeReserva1.Add(habitacion201);
            Reservas Reserva = new Reservas(999, fechaEspecifica, fechaEspecifica.AddDays(2), 2, cliente1, HabDeReserva1, "Pendiente");
            Console.WriteLine("Dias: " +Reserva.CantidadDiasReservados());
            Console.WriteLine("tiene mas de una habitacion en la reserva: " +Reserva.MultiplesHabitaciones());
            
            double CostoFinalReserva = 0;
            foreach (var h in HabDeReserva1)
            {
                CostoFinalReserva += ((h.getTipo().getCostoNoche()) * double.Parse(Reserva.CantidadDiasReservados()));
                
            }
            if(cliente1.getPremium() == true)
            {
                CostoFinalReserva=CostoFinalReserva * 0.80;
            }
            Console.WriteLine("Costo total: " + CostoFinalReserva);






            Console.ReadKey();
        }
    }
}
