using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecommerce.AdminManage
{
    public partial class LoginMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_Click(object sender, EventArgs e)
        {
/*            List<Client> LstClient = (List<Client>)Application["Clients"];

            if (LstClient == null)
            {
                LtlMsg.Text = "No clients found. Please register first.";
                return;
            }

            string Email = TxtEmail.Text;
            string Pass = TxtPassword.Text;

            foreach (Client client in LstClient)
            {
                if (client.EmailClie == Email && client.PasswordClie == Pass && client.Status == 1) // 1 מייצג מנהל
                {
                    Session["AdminLogin"] = client;
                    Response.Redirect("BackAdmin.Master"); // הפנה לעמוד ניהול
                    return;
                }
            }

            LtlMsg.Text = "Email or password error";*/
        }
    }
}