using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data; // זה בשביל קורא הנתונים
using System.Data.SqlClient; // בשביל האוביקטים לעבודה מול בסיס נתונים
using System.Configuration;
using DATA;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Ecommerce
{
    public class Global : System.Web.HttpApplication
    {
        // orel good
        protected void Application_Start(object sender, EventArgs e)
        {

            Application["Products"] = Product.GetAll();
            Application["Categories"] = Category.GetAll();
            Application["Cities"] = Cities.GetAll();
            Application["Clients"] = Client.GetAll();

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}