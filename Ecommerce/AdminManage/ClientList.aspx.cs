using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Ecommerce.AdminManage
{
    public partial class ClientList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // בדיקה אם קיים פרמטר למחיקה
                string delUid = Request["delUid"];
                if (!string.IsNullOrEmpty(delUid))
                {
                    int uid = int.Parse(delUid);
                    ClientDAL.Delete(uid);
                    Application["Clients"] = Client.GetAll();
                }

                // טעינת הלקוחות
                List<Client> ClientList = (List<Client>)Application["Clients"];
                RptClient.DataSource = ClientList;
                RptClient.DataBind();
            }
        }
    }
}
