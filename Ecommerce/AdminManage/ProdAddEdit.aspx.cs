using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Ecommerce.AdminManage
{
    public partial class ProdAdddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Pid = Request["Pid"] + ""; // יעזור לנו להבין שאין מוצר כזה במלאי ,Pid כדי שנוכל לשנות את הערך של הפרמטר string מבצעים המרה ל int כ class רשום ב Pid
                // של המוצר אז אם לא מופיע כנס ID מספר  URL זאת אומרת ברגע שהמנהל האתר לוחץ על ערוך מוצר אמור להופיע בכתובת ה  null אז זה  URL בכתובת ID אם הבקשה שנשלחה אין פרמטר שהוא מספר
                if (string.IsNullOrEmpty(Pid))
                {
                    Pid = "-1"; // -1 במידה אין תשנה ל
                }
                else // אחרת
                {
                    int pid = int.Parse(Pid); // int שהפכנו אותו למחרוזת ומחזירים אותו ל  Pid המרה של המשתנה למספר שלם לצורך חיפוש במאגר המוצרים, זאת אומרת לקחנו את ה 
                    List<Product> LstProd = (List<Product>)Application["Products"]; // Application שליפת רשימה של המוצרים לעמוד הזה זאת אומרת שאני מאפשר בעמוד הזה לגשת למוצרים שקיימים ב
                    for (int i = 0; i < LstProd.Count; i++) // לולאה שרצה על המוצרים ומחפשת את הקוד מוצר
                    {
                        // תנאי לעדכון נתונים למצור
                        if (LstProd[i].Pid == pid) // URL שרשום ב pid שרשום במאגר המוצרים שלנו שווה לפרמטר Pid בדיקה האם ה 
                        {
                            TxtPname.Text = LstProd[i].Pname;
                            TxtPrice.Text = LstProd[i].Price + ""; // אז ביצענו המרה Text והתיבה היא מסוג float בגלל שהמחיר הוא מסוג 
                            TxtPdesc.Text = LstProd[i].Pdesc;
                            ImgPicname.ImageUrl = "/uploads/products/" + LstProd[i].Picname;
                            HidPid.Value = Pid;
                        }
                    }
                }
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            string Picname = "";
            // נבדוק האם נבחר קובץ תמונה
            if (UploadPic.HasFile) // true אם נבחר קובץ השדה 
            {
                // נשמור את קובץ התמונה בתיקיית תחת שם חדש שנייצר בעצמנו
                // נעדכן את בשדה אם התמונה שיימור בבסיס הנתונים

                Picname = GlobFunc.GetRandStr(8); // הפרמטר הוא מקבל גודל של תווים של שם הקובץ (תמונה) ומועבר למשתנה 
                string OriginFileName = UploadPic.FileName; // למשתנה ID="UploadPic" פעולת השמה של 
                int index = OriginFileName.LastIndexOf('.'); // לקיחת מיקום - הנקודה מהסוף של המחרוזת הכוונה הנקודה של סיומת הקובץ
                string Ext = OriginFileName.Substring(index); // שהוא הנקודה והלאה ,  כל הסיומת של הקובץ index לקיחת התווים שנמצים במיקום 
                Picname += Ext; // את הסיומת המקורית של הקובץ שהועלה Random הוספת למחרוזת הקיימת שיבצענו באמצעות הפונקציה 
                string FullPath = Server.MapPath("/uploads/products/");// /uploads/products/  מחזירה את הנתיב המלא מהשרת ועד התיקיה Server.MapPath(OriginFileName)
                UploadPic.SaveAs(FullPath + Picname); // שמירת התמונה שהועלתה - הנתיב המלא עם שם התמונה שיצרנו עבורה
            }
            else
            {
                int index = ImgPicname.ImageUrl.LastIndexOf('/'); // לקיחת מיקום  התוו /  מהסוף של המחרוזת הכוונה / של נתיב הקובץ
                Picname = ImgPicname.ImageUrl.Substring(index + 1); // לקחי
            }


            // הוספת מוצר חדש
            string Sql = "";
            if (HidPid.Value == "-1")  // בדיקה אם הערך המוסתר שווה ל 1- אז כנס
            {
                Sql = "insert into T_Product(Pname,Price,Pdesc,Picname) values";
                Sql += $"(N'{TxtPname.Text}', '{TxtPrice.Text}', N'{TxtPdesc.Text}', N'{Picname}')";
            }
            else
            {
                Sql = "Update T_Product set";
                Sql += $" Pname = N'{TxtPname.Text}',";
                Sql += $" Price = {TxtPrice.Text},";
                Sql += $" Pdesc = N'{TxtPdesc.Text}',";
                Sql += $" Picname = N'{Picname}' ";
                Sql += $" where Pid = {HidPid.Value}";
            }




            // הגדרת מחרוזת התחברות לבסיס הנתונים
            // node.js <- .env זה כמו , Web.config שליפת מחרוזת התחברות מתוך קובץ הגדרות באפליקציה/שרת נמצא ב
            string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection Conn = new SqlConnection(ConnStr); // יצירת אובייקט מסוג צינור והגדרת מחרוזת התחברות של הצינור לבסיס הנתונים (הבנאי הזה מקבל את האובייקט שהוא מחרוזת התחברות לבסיס הנתונים) מחרוזת התחברות
            Conn.Open(); // פתיחת הצינור לבסיס הנתונים (מעבר של בסיס הנתונים) פתיחה
            SqlCommand Cmd = new SqlCommand(Sql, Conn); // יצירת אובייקט/עצם - הפרמטר השני הוא המחרוזת התחברות,  והפרמטר השני זה משתנה עם ערך של שאילתה
            Cmd.ExecuteNonQuery(); // הפעלת השאילתה שלא מחזירה נתונים כלומר מבצעת הוספה או עדכון

            // טעינה מחודשת של רשימת המוצרים אל אפליקיישן
            List<Product> LstProd = new List<Product>(); // יצירת רשימה של מוצרים
            Sql = "SELECT * FROM T_Product"; // שאילתה
            Cmd.CommandText = Sql;
            SqlDataReader Dr = Cmd.ExecuteReader(); // הפעלת השאילתה וקבלת תוצאות השאילתה לתוך אובייקט קורא נתונים

            while (Dr.Read()) // false אם ישנתונים אז תתבצע כניסה ללואה, אם לא נמצא נתונים לא תתבצע כניסה ללולאה יחזיר true אם נמצא נתונים יחזיר לנו ,Dr פונקציה שמחפשת שנתונים באובייקט 
            {
                Product Tmp = new Product()
                {
                    Pid = int.Parse(Dr["Pid"] + ""), // int הוא מסוג Pid כי int ל (Dr) המרה של אובייקט 
                    Pname = Dr["Pname"] + "", // string ל (Dr) המרת האובייקט 
                    Price = float.Parse(Dr["Price"] + ""), // float המרת האובייקט ל 
                    Picname = Dr["Picname"] + "", // string ל (Dr) המרת האובייקט 
                                                  //  Cid = int.Parse(Dr["Cid"] + ""), // int הוא מסוג Cid כי int ל (Dr) המרה של אובייקט 
                    Pdesc = Dr["Pdesc"] + "",  // string ל (Dr) המרת האובייקט 
                                               //  AddDate = DateTime.Parse(Dr["AddDate"] + "")  //  לתאריך (Dr) המרת האובייקט 
                };
                LstProd.Add(Tmp); // הוספת המוצר לרשימת המוצרים
            }

            Conn.Close(); // סגירת הצינור לבסיס הנתונים (סגירת מעבר הנתונים) הוא חייב להיות בסוף
            Application["Products"] = LstProd; // שמירת רשימת המוצרים באפליקיישן
            Response.Redirect("ProductsList.aspx");
        }
    }
}
