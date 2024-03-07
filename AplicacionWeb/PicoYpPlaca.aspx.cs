using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class PicoYpPlaca : System.Web.UI.Page
    {
        Servicio.PicoPlaca.Service1Client servicio = new Servicio.PicoPlaca.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void msn(string mensaje, string titulo, MessageBox.Icon icono)
        {
            X.Msg.Show(new MessageBoxConfig
            {
                Title = titulo,
                Message = mensaje,
                Buttons = MessageBox.Button.OK,
                Icon = icono
            });
        }

        [DirectMethod]
        protected void BuscarPlaca(object sender, EventArgs e)
        {
           BuscarPlacas();
        }

        protected void BuscarPlacas()
        {
            string pico = this.IdPicoPlaca.Text;

            if (this.IdPicoPlaca.Text == "")
            {
                msn("Ingreso Texto", "Notificación", MessageBox.Icon.ERROR);
            }
            else
            {
                if (this.IdPicoPlaca.Text.Length<8 || this.IdPicoPlaca.Text.Length > 8)
                {
                    msn("La placa tiene que tener 8 caracteres", "Notificación", MessageBox.Icon.ERROR);
                }
                else
                {
                    string res = servicio.GetPicoYPlaca(pico.ToString());
                    msn("" + res, "Notificación", MessageBox.Icon.INFO);
                }
            }

        }
    }
}