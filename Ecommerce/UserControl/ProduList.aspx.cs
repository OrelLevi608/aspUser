using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.UserControl
{
    public partial class ProduList : System.Web.UI.Page
    {
        public int MaxProducts { get; set; } = 10; // לדוגמא, ניתן לשנות לערך הרצוי
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> ProduList = (List<Product>)Application["Products"];
                if (ProduList != null)
                {
                    RptProducts.DataSource = ProduList.Take(MaxProducts);
                    RptProducts.DataBind();
                }
                else
                {
                    // טיפול במקרה שאין מוצרים ברשימה
                    Response.Write("No products found.");
                }
            }
        }
    }
}
