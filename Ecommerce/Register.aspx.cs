using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cities> CityList = (List<Cities>)Application["Cities"];
                for (int i = 0; i < CityList.Count; i++)
                {
                    DDLCity.Items.Add(new ListItem(CityList[i].CityName + ""));
                }
                for (int i = 0; i < CityList.Count; i++)
                {
                    DDLCityCode.Items.Add(new ListItem(CityList[i].CityCode + ""));
                }
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            if (!check1.Checked)
            {
                label.Text = "You must accept the Terms of Use to continue.";
                return;
            }

            List<Client> LstClient = (List<Client>)Application["Clients"] ?? new List<Client>();

            Client newClient = new Client
            {
                ClientID = LstClient.Count + 1,
                EmailClie = TxtEmail.Text,
                PasswordClie = TxtPassword.Text
            };

            LstClient.Add(newClient);
            Application["Clients"] = LstClient;

            Response.Redirect("Login.aspx");
        }
    }
}
