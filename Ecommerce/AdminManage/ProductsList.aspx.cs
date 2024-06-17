using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.AdminManage
{
    public partial class ProductsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string delPid = Request["delPid"];
                if (!string.IsNullOrEmpty(delPid))
                {
                    int pid = int.Parse(delPid);
                    ProductDAL.Delete(pid);
                    Application["Products"] = Product.GetAll();
                }

                LoadProductData();
            }
        }

        private void LoadProductData()
        {
            List<Product> ProductList = (List<Product>)Application["Products"];
            if (ProductList == null)
            {
                ProductList = Product.GetAll();
                Application["Products"] = ProductList;
            }
            RptProducts.DataSource = ProductList;
            RptProducts.DataBind();
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int productId = int.Parse(btn.CommandArgument);
            Response.Redirect("ProdAddEdit.aspx?Pid=" + productId);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int productId = int.Parse(btn.CommandArgument);
            ProductDAL.Delete(productId);
            LoadProductData();
        }
    }
}
