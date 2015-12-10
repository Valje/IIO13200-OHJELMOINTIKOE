using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H3340_T2 : System.Web.UI.Page
{
    DataSet ds;
    DataTable dt;
    DataView dv;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblStatus.Text = "";

        if (!IsPostBack)
        {
            populateTable();
        }
    }

    private void setDataThings()
    {
        try
        {
            string path = MapPath(ConfigurationManager.AppSettings["tyontekijatXML"]);
            string file = path;
            ds = new DataSet();
            dt = new DataTable();
            dv = new DataView();
            ds.ReadXml(file);
            dt = ds.Tables[0]; // voisi viitata myös taulun nimellä, nyt satutaan tietämään että tiedostossa on vain yksi taulu
            dv = dt.DefaultView;
        }
        catch (Exception ex)
        {
            // Virheviesti on informatiivinen, muttei välttämättä tietoturvallinen.
            lblStatus.Text = "Tietojen haku ei onnistunut: " + ex.Message;
        }
    }

    private void populateTable()
    {
        setDataThings();
        gridTyontekijat.DataSource = dv;
        gridTyontekijat.DataBind();
                
    }

    protected void btnVakkarit_Click(object sender, EventArgs e)
    {
        setDataThings();

        EnumerableRowCollection<DataRow> query = from tyontekija in dt.AsEnumerable()
                                                 where tyontekija.Field<string>("tyosuhde").StartsWith("vakitu")
                                                 select tyontekija;

        dv = query.AsDataView();

        gridTyontekijat.DataSource = dv;
        gridTyontekijat.DataBind();

        lblStatus.Text = "Yhteensä " + dv.Count + " työntekijää löytyi." + "\n";

    }

    protected void btnMaaraaikaiset_Click(object sender, EventArgs e)
    {
        setDataThings();

        EnumerableRowCollection<DataRow> query = from tyontekija in dt.AsEnumerable()
                                                 where tyontekija.Field<string>("tyosuhde").StartsWith("määräa")
                                                 select tyontekija;

        dv = query.AsDataView();

        gridTyontekijat.DataSource = dv;
        gridTyontekijat.DataBind();

        lblStatus.Text = "Yhteensä " + dv.Count + " työntekijää löytyi.";
    }

    protected void btnMuut_Click(object sender, EventArgs e)
    {
        setDataThings();

        EnumerableRowCollection<DataRow> query = from tyontekija in dt.AsEnumerable()
                                                 where !tyontekija.Field<string>("tyosuhde").StartsWith("vakitu") &&
                                                       !tyontekija.Field<string>("tyosuhde").StartsWith("määräa")
                                                 select tyontekija;

        dv = query.AsDataView();

        gridTyontekijat.DataSource = dv;
        gridTyontekijat.DataBind();

        lblStatus.Text = "Yhteensä " + dv.Count + " työntekijää löytyi.";
    }

    protected void btnKaikki_Click(object sender, EventArgs e)
    {
        populateTable();
        lblStatus.Text = "Yhteensä " + dv.Count + " työntekijää löytyi.";
    }
}