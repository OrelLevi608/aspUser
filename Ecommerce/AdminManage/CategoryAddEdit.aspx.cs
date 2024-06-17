using System;
using System.Collections.Generic;
using System.Web.UI;
using BLL;

namespace Ecommerce.AdminManage
{
    public partial class CategoryAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Cid = Request["Cid"] + "";
                if (string.IsNullOrEmpty(Cid))
                {
                    Cid = "-1";
                }
                else
                {
                    int cid = int.Parse(Cid);
                    List<Category> CategoryList = (List<Category>)Application["Categories"];
                    for (int i = 0; i < CategoryList.Count; i++)
                    {
                        if (CategoryList[i].Cid == cid)
                        {
                            TxtCname.Text = CategoryList[i].Cname;
                            TxtCdesc.Text = CategoryList[i].Cdesc;
                            TxtPicname.Text = CategoryList[i].Picname;
                            HidCid.Value = Cid;
                        }
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            if (HidCid.Value == "-1")
            {
                category.Cid = -1;
            }
            else
            {
                category.Cid = int.Parse(HidCid.Value);
            }
            category.Cname = TxtCname.Text;
            category.Cdesc = TxtCdesc.Text;
            category.Picname = TxtPicname.Text;

            category.Save();
            Application["Categories"] = Category.GetAll();

            Response.Redirect("CategoryList.aspx");
        }
    }
}
