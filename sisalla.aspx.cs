using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class sisalla : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.BufferOutput = true;
        if (!(bool)Session["isLoggedIn"])
        {
            Response.Redirect("H3340_T3.aspx");
        }
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Session["isLoggedIn"] = false;
        Response.Redirect(Request.RawUrl);
    }

    protected void btnKirjaa_Click(object sender, EventArgs e)
    {
        List<string> tuntimerkinnat = new List<string>();

        tuntimerkinnat.Add(tbNimi.Text.ToString());
        tuntimerkinnat.Add(tbPVM.Text.ToString());
        tuntimerkinnat.Add(tbTunnit.Text.ToString());

        WriteXMLFile();

    }

    public void WriteXMLFile()
    {
        string path = MapPath(ConfigurationManager.AppSettings["tunnitXML"]);
        string file = path;

        XDocument doc = XDocument.Load(file);
        XElement tuntilistat = doc.Element("tuntilistat");
        tuntilistat.Add(new XElement("kirjaus",
                   new XElement("nimi", tbNimi.Text),
                   new XElement("PVM", tbPVM.Text),
                   new XElement("tunnit", tbTunnit.Text)));
        doc.Save(file);
    }
}