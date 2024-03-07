﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using Transaccion.Interfaz;

namespace WcfPicoPlaca
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        ITransaccionColegio transaccionColegio;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Service1(ITransaccionColegio transaccionColegio)
        {
            this.transaccionColegio = transaccionColegio;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string GetPicoYPlaca(string valorBusqueda)
        {
            string user = transaccionColegio.GetPicoYPlaca(valorBusqueda);
            return user;
        }

    }
}
