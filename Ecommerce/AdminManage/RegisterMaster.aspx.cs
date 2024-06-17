using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecommerce.AdminManage
{
    public partial class RegisterMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_Click(object sender, EventArgs e)
        {
          /*  List<Client> LstClient = (List<Client>)Application["Clients"] ?? new List<Client>();

            Client newClient = new Client
            {
                ClientID = LstClient.Count + 1,
                FirstName = TxtFname.Text,
                LastName = TxtLname.Text,
                EmailClie = TxtEmail.Text,
                PasswordClie = TxtPassword.Text,
                Status = 1, // נניח ש-1 מייצג מנהל
                AddDate = DateTime.Now
            };

            LstClient.Add(newClient);
            Application["Clients"] = LstClient;

            Response.Redirect("Login.aspx");*/
        }
    }
}