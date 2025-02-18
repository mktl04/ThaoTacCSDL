using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class QLMH : System.Web.UI.Page
    {
        MonHocDAO mhDAO = new MonHocDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvMonHoc.DataSource = mhDAO.getAll();
                gvMonHoc.DataBind();
            }
        }
    }
}