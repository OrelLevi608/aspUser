using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DATA
{
    public class DbContext
    {
        public string ConnStr { get; set; } //שדה עבור מחרוזת לבסיס הנתונים
        public SqlConnection Conn { get; set; } // שדה עבור אובייקט הצינור לבסיס הנתונים

        public DbContext()
        {
            // טעינת הגדרות המחרוזת התחברות, יצירת אוביקט צינור ופתיחת הצינור 
            ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString; // שינוי ל-"ConnString"
            Conn = new SqlConnection(ConnStr); // יצירת אובייקט מסוג צינור והגדרת מחרוזת התחברות של הצינור לבסיס הנתונים
            Conn.Open();
        }

        public void Close()
        {
            Conn.Close(); // סגירת הצינור
        }

        public int ExecuteNonQuery(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn); // יצירת אובייקט/עצם - הפרמטר הראשון הוא מחרוזת השאילתה והפרמטר השני הוא חיבור לבסיס הנתונים
            return Cmd.ExecuteNonQuery(); // הפעלת השאילתה שלא מחזירה נתונים כלומר מבצעת הוספה או עדכון
        }

        public DataTable Execute(string Sql) // פונקציה משמשת לשליפת נתונים מבסיס הנתונים
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn); // יצירת אובייקט תותח פקודות
            SqlDataAdapter Da = new SqlDataAdapter(Cmd); // יצירת אובייקט מסוג מתאם נתונים
            DataTable Dt = new DataTable(); // יצירת אובייקט מסוג טבלת נתונים
            Da.Fill(Dt); // מילוי טבלת הנתונים בתוצאות הפעלת השאילתה 
            return Dt; // החזרת טבלת הנתונים
        }
    }
}
