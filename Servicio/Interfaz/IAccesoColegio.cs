using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio.Interfaz
{
    public interface IAccesoColegio
    {
        void Inicializar();

        string GetPicoYPlaca(string valorBusqueda);


    }
}
