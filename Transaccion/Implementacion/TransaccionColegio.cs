using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Servicio.Implementacion;
using Transaccion.Interfaz;

namespace Transaccion.Implementacion
{
    public class TransaccionColegio: ITransaccionColegio
    {
        public AccesoColegio accesoColegio;
        public TransaccionColegio(AccesoColegio accesoColegio)
        {
            this.accesoColegio = accesoColegio;
        }


        public string GetPicoYPlaca(string valorBusqueda)
        {
            string user = accesoColegio.GetPicoYPlaca(valorBusqueda);
            return user;
        }

    }
}
