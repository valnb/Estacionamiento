using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    public class UsuarioBO
    {
        string nomUsuario;
        int idUsuarios;

        public string NomUsuario
        {
            get { return nomUsuario; }
            set { nomUsuario = value; }
        }
        
        public int IdUsuarios
        {
            get { return idUsuarios; }
            set { idUsuarios = value; }
        }
            
    }
}
