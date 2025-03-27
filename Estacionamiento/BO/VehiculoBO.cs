using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    internal class VehiculoBO
    {
        string placa;
        string modelo;
        string color;
        int horaEntrada;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }
        
    }
}
