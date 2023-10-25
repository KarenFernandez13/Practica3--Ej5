using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3_Ej5
{
    internal class TipoHabitacion
    {
        private int codigoTipo;
        private string NombreTipo;
        private double costoNoche;

        public TipoHabitacion(int codigoTipo, string nombreTipo, double costoNoche)
        {
            this.codigoTipo = codigoTipo;
            this.NombreTipo = nombreTipo;
            this.costoNoche = costoNoche;
        }

    }
}
