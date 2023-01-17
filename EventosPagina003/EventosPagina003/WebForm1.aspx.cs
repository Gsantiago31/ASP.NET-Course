using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosPagina003
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("1) PreInit <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("2) Init <br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("3) InitComplete <br/>");
        }
        protected void Page_Preload(object sender, EventArgs e)
        {
            Response.Write("4) Preload <br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("5) Load <br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("6) LoadComplete <br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("7) PreRender <br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("8) PreRenderComplete <br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            // Comentado por que no tiene sentido el uso de Response en este evento
            // por que cuando llega unload, la página ya no existe
            // Response.Write("9) Unload <br/>");
        }
    }
}