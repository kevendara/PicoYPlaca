using Entidades;
using Repositorio.Implementacion;
using Repositorio.Interfaz;
using Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Servicio.Implementacion
{
    public class AccesoColegio : IAccesoColegio
    {

        IPaPicoYPlaca picoPlacaRepositorio;

        public AccesoColegio(
            IPaPicoYPlaca picoPlacaRepositorio)
        {
            this.picoPlacaRepositorio = picoPlacaRepositorio;
        }

        public void Inicializar()
        {
            picoPlacaRepositorio.Inicializar();
        }

        //Pico Y placa
        public string GetPicoYPlaca(string placa)
        {
            string cadena, ultimoDigito, resultado = "", numeros, letras;
            int contador;

            cadena = Regex.Replace(placa, @"[^\w\s.!@$%^&*()\-\/]+", "");

            contador = cadena.Length;
            ultimoDigito = cadena.Substring(contador - 1, 1);

            numeros = cadena.Substring(contador - 4, 4);
            letras = cadena.Substring(0, 3);

            if (int.TryParse(numeros, out _) == true && Regex.IsMatch(letras, @"^[a-zA-Z]+$"))
            {

                if (ultimoDigito == "1" || ultimoDigito == "2")
                {
                    resultado = "Su placa " + placa + " no circula el día Lunes de 06:00 a 09:30 y de 16:00 a 21:00."
                    + "\n" + "Su placa " + placa + " puede circular Sábado, Domingo y Feriado.";
                }

                if (ultimoDigito == "3" || ultimoDigito == "4")
                {
                    resultado = "Su placa " + placa + " no circula el día Martes de 06:00 a 09:30 y de 16:00 a 21:00."
                    + "\n" + "Su placa " + placa + " puede circular Sábado, Domingo y Feriado.";
                }

                if (ultimoDigito == "5" || ultimoDigito == "6")
                {
                    resultado = "Su placa " + placa + " no circula el día Miércoles de 06:00 a 09:30 y de 16:00 a 21:00."
                    + "\n" + "Su placa " + placa + " puede circular Sábado, Domingo y Feriado.";
                }

                if (ultimoDigito == "7" || ultimoDigito == "8")
                {
                    resultado = "Su placa " + placa + " no circula el día Jueves de 06:00 a 09:30 y de 16:00 a 21:00."
                    + "\n" + "Su placa " + placa + " puede circular Sábado, Domingo y Feriado.";
                }

                if (ultimoDigito == "9" || ultimoDigito == "0")
                {
                    resultado = "Su placa " + placa + " no circula el día Viernes de 06:00 a 09:30 y de 16:00 a 21:00."
                    + "\n" + "Su placa " + placa + " puede circular Sábado, Domingo y Feriado.";
                }
            }
            else
            {
                resultado = "Su placa: " + placa + " no cumple con el formato establecido de una placa.";
            }

            return resultado;

            /*picoPlacaRepositorio.Inicializar();
            --var parametros = new Dictionary<string, string>();

            List<pa_PicoYPlaca> lista =
                    picoPlacaRepositorio.SqlQuery("execute pa_PicoYPlaca '" + placa + "'", parametros, 0).ToList();

            string resultado="";

            for(int i = 0; i < lista.Count; i++) {
                resultado=lista[0].ToString();
            }
            return resultado;*/
        }
    }
}
