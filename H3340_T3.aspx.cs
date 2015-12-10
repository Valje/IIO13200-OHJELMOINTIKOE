using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class H3340_T3 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["isLoggedIn"] != null)
        {
            Response.BufferOutput = true;
            if ((bool)Session["isLoggedIn"])
            {
                Response.Redirect("sisalla.aspx");
            }
        }

    }
    private void setDataThings()
    {
        try
        {
            string path = MapPath(ConfigurationManager.AppSettings["kayttajatXML"]);
            string file = path;
            XDocument doc = XDocument.Load(file);

            
        }
        catch (Exception ex)
        {
            // Virheviesti on informatiivinen, muttei välttämättä tietoturvallinen.
            lblStatus.Text = "Tietojen haku ei onnistunut: " + ex.Message;
        }
    }

    protected void btnKirjaudu_Click(object sender, EventArgs e)
    {
        if (tbNimi.Text == "sisaan" && tbSalasana.Text == "sala")
        {
            Session["isLoggedIn"] = true;
        }
        else
        {
            Session["isLoggedIn"] = false;
        }
    }
}