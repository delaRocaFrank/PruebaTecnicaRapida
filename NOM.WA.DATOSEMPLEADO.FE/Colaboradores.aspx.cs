using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NOM.WA.DATOSEMPLEADO.FE
{
    public partial class Colaboradores : System.Web.UI.Page
    {
        int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            string url = "https://localhost:44368/Colaborador";
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("Frank","123");
            var json = client.DownloadString(url);

            var m = JsonConvert.DeserializeObject<DataTable>(json);

            GridView1.DataSource = m;
            
                GridView1.DataBind();
            
            
        }
        

       

        protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
        {


            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selected = GridView1.Rows[index];
                TableCell Cell = selected.Cells[5];
                int Edad = Convert.ToInt32(Cell.Text);
                if(Edad >= 18 && Edad <= 25)
                    Response.Write("<script>alert('FUERA DE PELIGRO');</script>");
                else if (Edad >25 && Edad <=50)
                    Response.Write("<script>alert('TENGA CUIDADO');</script>");
                else if (Edad > 50)
                    Response.Write("<script>alert('POR FAVOR QUEDARSE EN CASA');</script>");
            }

        }
    
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_Init(object sender, EventArgs e)
        {
            ButtonField Riesgo = new ButtonField();
            Riesgo.ButtonType = ButtonType.Button;
            Riesgo.Text = "NIVEL RIESGO";
            Riesgo.CommandName = "Select";


            GridView1.Columns.Add(Riesgo);
        }
    }
}