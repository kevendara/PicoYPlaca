using Contexto;
using Entidades;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Implementacion
{
    public class pa_PicoYPlacaRepositorio : Repositorio <pa_PicoYPlaca>, IPaPicoYPlaca
    {
        public pa_PicoYPlacaRepositorio(ContextoUniversidad contexto)
            : base(contexto)
        {
        }

        public void Inicializar()
        {
            this.Context = new ContextoUniversidad();
        }
    }
}
