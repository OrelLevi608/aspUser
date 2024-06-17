using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Ecommerce.AdminManage
{
    public partial class CityAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string CityId = Request["CityId"] + "";
                if (string.IsNullOrEmpty(CityId))
                {
                    CityId = "-1";
                }
                else
                {
                    int cityid = int.Parse(CityId);
                    List<Cities> CityList = (List<Cities>)Application["Cities"];
                    for (int i = 0; i < CityList.Count; i++)
                    {
                        if (CityList[i].CityID == cityid)
                        {
                            TxtCityName.Text = CityList[i].CityName;
                            TxtCityCode.Text = CityList[i].CityCode + "";
                            HidCityId.Value = CityId;
                        }
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Cities city = new Cities();
            if (HidCityId.Value == "-1")
            {
                city.CityID = -1;
            }
            else
            {
                city.CityID = int.Parse(HidCityId.Value);
            }
            city.CityName = TxtCityName.Text;
            city.CityCode = int.Parse(TxtCityCode.Text);

            Cities.Save(city); // קריאה נכונה לפונקציה סטטית
            Application["Cities"] = Cities.GetAll();

            Response.Redirect("CityList.aspx");
        }
    }
}
