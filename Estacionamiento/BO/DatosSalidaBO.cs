using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    internal class DatosSalidaBO
    {
        string puesto;
        int horaSalida;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public int HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }
            
    }
}
