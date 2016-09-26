using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PesquisaEleitoral.DataSet
{
    public partial class RelatorioVotos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_VoltarThree_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home");
        }
    }
}