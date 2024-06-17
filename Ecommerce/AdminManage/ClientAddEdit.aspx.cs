using System;
using System.Collections.Generic;
using System.Web.UI;
using BLL;

namespace Ecommerce.AdminManage
{
    public partial class ClientAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ClientID = Request["ClientID"] + "";
                if (string.IsNullOrEmpty(ClientID))
                {
                    ClientID = "-1";
                }
                else
                {
                    int uid = int.Parse(ClientID);
                    List<Client> ClientList = (List<Client>)Application["Clients"];
                    for (int i = 0; i < ClientList.Count; i++)
                    {
                        if (ClientList[i].ClientID == uid)
                        {
                            TxtFirstName.Text = ClientList[i].FirstName;
                            TxtLastName.Text = ClientList[i].LastName;
                            TxtCity.Text = ClientList[i].City;
                            TxtCityCode.Text = ClientList[i].CityCode + "";
                            TxtPhone.Text = ClientList[i].Phone;
                            TxtEmail.Text = ClientList[i].EmailClie;
                            HidUid.Value = ClientID;
                        }
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (HidUid.Value == "-1")
            {
                client.ClientID = -1;
            }
            else
            {
                client.ClientID = int.Parse(HidUid.Value);
            }
            client.FirstName = TxtFirstName.Text;
            client.LastName = TxtLastName.Text;
            client.City = TxtCity.Text;
            client.CityCode = int.Parse(TxtCityCode.Text);
            client.Phone = TxtPhone.Text;
            client.EmailClie = TxtEmail.Text;

            client.Save();
            Application["Clients"] = Client.GetAll();

            Response.Redirect("ClientList.aspx");
        }
    }
}
