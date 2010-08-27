using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void WebDataMenu1_ItemClick(object sender, Infragistics.Web.UI.NavigationControls.DataMenuItemEventArgs e)
    {
        if (e.Item.Value.Equals("Index"))
            Response.Redirect("Index.aspx");

        if (e.Item.Value.Equals("Perfil"))
            Response.Redirect("Perfil.aspx");

        if (e.Item.Value.Equals("Contato"))
            Response.Redirect("Contato.aspx");

        if (e.Item.Value.Equals("Partido"))
            Response.Redirect("Partido.aspx");

        if (e.Item.Value.Equals("Fotos"))
            Response.Redirect("Fotos.aspx");

        if (e.Item.Value.Equals("Propostas"))
            Response.Redirect("Propostas.aspx");

    }
}
