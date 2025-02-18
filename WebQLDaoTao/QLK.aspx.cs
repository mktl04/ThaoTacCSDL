using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class QLK : System.Web.UI.Page
    {
        KhoaDAO khDAO = new KhoaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvKhoa.DataSource = khDAO.getAll();
                gvKhoa.DataBind();
            }

        }
        protected void btThem_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            if (khDAO.findById(makh) != null)
            {
                lbThongBao.Text = "mã khoa đã tồn tại. chọn mã khác nhé";
                return;
            }
            //goi phuong thuc thêm khoa vào csdl
            khDAO.Insert(makh, tenkh);
            lbThongBao.Text = "đã thêm 1 khoa";
            //liên kết dữ liệu cho gvkhoa
            gvKhoa.DataSource = khDAO.getAll();
            gvKhoa.DataBind();
        }
    }
}