using BLL;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Ecommerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
/*            List<Client> LstClient = (List<Client>)Application["Clients"]; // הגדרת רשימה עבור לקוחות

            if (LstClient == null)
            {
                LtlMsg.Text = "No clients found. Please register first.";
                return;
            }

            string Email = TxtEmail.Text; // השמת הערך שהמשתמש הכניס בתיבת טקסט של המייל
            string Pass = TxtPassword.Text; // השמת הערך שהמשתמש הכניס בתיבת טקסט של הסיסמה

            foreach (Client client in LstClient) // לולאה שעוברת על רשימת הלקוחות
            {
                if (client.EmailClie == Email && client.PasswordClie == Pass) // אם נמצא לקוח עם המייל והסיסמה אז התחבר
                {
                    Session["Login"] = client; // שמירת האובייקט של הלקוח בסשן
                    Response.Redirect("Home.aspx"); // מעבר לעמוד הראשי
                    return;
                }
            }

            LtlMsg.Text = "Email or password error"; // הודעת שגיאה אם המייל או הסיסמה לא נכונים*/
        }
    }
}
