using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int CityCode { get; set; }
        public string Phone { get; set; }
        public string EmailClie { get; set; }
        public string PasswordClie { get; set; }
        public int Status { get; set; }
        public DateTime AddDate { get; set; }

        // פונקציה להחזרת כל הלקוחות
        public static List<Client> GetAll()
        {
            return ClientDAL.GetAll();
        }

        // פונקציה להחזרת לקוח לפי מזהה
        public static Client GetById(int id)
        {
            return ClientDAL.GetById(id);
        }

        // פונקציה לשמירת לקוח
        public void Save()
        {
            ClientDAL.Save(this);
        }

        // פונקציה למחיקת לקוח לפי מזהה
        public static void Delete(int id)
        {
            ClientDAL.Delete(id);
        }
    }
}
