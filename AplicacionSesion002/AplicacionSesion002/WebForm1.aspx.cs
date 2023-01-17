using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionSesion002
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // La sesión de usuario es una instancia de un browser
        // pero las sesiones usan cookies, las cuales pueden ser compartidas por dos instancias del browser
        // y se consideraría la misma sesión
        // Si abrimos en otro browser veremos que tenemos dos sesiones y una aplicación instanciada

        // Si no queremos tener cookie para nuestra sesión , en web.config
        // // <sessionState mode = "InProc" cookieless="true"> </sessionState>
        // Y nos manda visiblemente el sessionID

        //Este handler se ejecuta cuando se carga la página
        protected void Page_Load(object sender, EventArgs e)
        {
            // El servidor manda la respuesta al cliente
            Response.Write("Cantidad de aplicaciones instanciadas " + Application["Aplicaciones"] + "<br/>");
            Response.Write("Cantidad de sesiones de usuario " + Application["SesionesUsuario"]);
        }
    }
}