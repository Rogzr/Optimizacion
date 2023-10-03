using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1.Models
{
    public class Vehiculo
    {
        // ID del vehiculo
        public int ID { get; set; }
        public double Capacidad { get; set; }
        public long LatitudOrigen { get; set;}
        public long LongitudOrigen { get; set; }
        public DateTime FechaDisp { get; set; }

        public Vehiculo() { }

        public Vehiculo(int iD, double capacidad, long latitudOrigen, long longitudOrigen, DateTime fechaDisp)
        {
            ID = iD;
            Capacidad = capacidad;
            LatitudOrigen = latitudOrigen;
            LongitudOrigen = longitudOrigen;
            FechaDisp = fechaDisp;
        }
    }
}