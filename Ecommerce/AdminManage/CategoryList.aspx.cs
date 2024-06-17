using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Ecommerce.AdminManage
{
    public partial class CategoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string delCid = Request["delCid"];
                if (!string.IsNullOrEmpty(delCid))
                {
                    int cid = int.Parse(delCid);
                    CategoryDAL.Delete(cid);
                    Application["Categories"] = Category.GetAll();
                }

                List<Category> CategoryList = (List<Category>)Application["Categories"];
                RptCat.DataSource = CategoryList;
                RptCat.DataBind();
            }
        }
    }
}
