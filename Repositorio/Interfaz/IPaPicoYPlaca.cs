using Core;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaz
{
    public interface IPaPicoYPlaca : IRepositorio<pa_PicoYPlaca>
    {
        void Inicializar();
    }
}
