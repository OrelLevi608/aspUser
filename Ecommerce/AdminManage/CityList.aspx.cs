using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Ecommerce.AdminManage
{
    public partial class CityList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // בדיקה אם קיים פרמטר למחיקה
                string delCityID = Request["delCityID"];
                if (!string.IsNullOrEmpty(delCityID))
                {
                    int cityID = int.Parse(delCityID);
                    CitiesDAL.Delete(cityID);
                    Application["Cities"] = Cities.GetAll();
                }

                // טעינת הערים
                List<Cities> CityList = (List<Cities>)Application["Cities"];
                RptCity.DataSource = CityList;
                RptCity.DataBind();
            }
        }
    }
}
