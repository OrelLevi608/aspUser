using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientDAL
    {
        public static List<Client> GetAll()
        {
            DbContext Db = new DbContext();
            string Sql = "SELECT * FROM T_Client";
            DataTable Dt = Db.Execute(Sql);
            List<Client> ClientList = new List<Client>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Client c = new Client
                {
                    ClientID = int.Parse(Dt.Rows[i]["ClientID"] + ""),
                    FirstName = Dt.Rows[i]["FirstName"] + "",
                    LastName = Dt.Rows[i]["LastName"] + "",
                    City = Dt.Rows[i]["City"] + "",
                    CityCode = int.Parse(Dt.Rows[i]["CityCode"] + ""),
                    Phone = Dt.Rows[i]["Phone"] + "",
                    EmailClie = Dt.Rows[i]["EmailClie"] + "",
                    PasswordClie = Dt.Rows[i]["PasswordClie"] + "",
                    Status = int.Parse(Dt.Rows[i]["Status"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                ClientList.Add(c);
            }
            Db.Close();
            return ClientList;
        }

        public static Client GetById(int id)
        {
            DbContext Db = new DbContext();
            string Sql = $"SELECT * FROM T_Client WHERE ClientID={id}";
            DataTable Dt = Db.Execute(Sql);
            Client c = null;
            if (Dt.Rows.Count > 0)
            {
                c = new Client
                {
                    ClientID = int.Parse(Dt.Rows[0]["ClientID"] + ""),
                    FirstName = Dt.Rows[0]["FirstName"] + "",
                    LastName = Dt.Rows[0]["LastName"] + "",
                    City = Dt.Rows[0]["City"] + "",
                    CityCode = int.Parse(Dt.Rows[0]["CityCode"] + ""),
                    Phone = Dt.Rows[0]["Phone"] + "",
                    EmailClie = Dt.Rows[0]["EmailClie"] + "",
                    PasswordClie = Dt.Rows[0]["PasswordClie"] + "",
                    Status = int.Parse(Dt.Rows[0]["Status"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return c;
        }

        public static void Save(Client client)
        {
            string sql = "";
            if (client.ClientID == -1)
            {
                sql = "INSERT INTO T_Client (FirstName, LastName, City, CityCode, Phone, EmailClie, PasswordClie, Status, AddDate) VALUES ";
                sql += $"('{client.FirstName}', '{client.LastName}', '{client.City}', {client.CityCode}, '{client.Phone}', '{client.EmailClie}', '{client.PasswordClie}', {client.Status}, '{client.AddDate}')";
            }
            else
            {
                sql = "UPDATE T_Client SET ";
                sql += $"FirstName = '{client.FirstName}', ";
                sql += $"LastName = '{client.LastName}', ";
                sql += $"City = '{client.City}', ";
                sql += $"CityCode = {client.CityCode}, ";
                sql += $"Phone = '{client.Phone}', ";
                sql += $"EmailClie = '{client.EmailClie}', ";
                sql += $"PasswordClie = '{client.PasswordClie}', ";
                sql += $"Status = {client.Status}, ";
                sql += $"AddDate = '{client.AddDate}' ";
                sql += $"WHERE ClientID = {client.ClientID}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(sql);
            Db.Close();
        }

        public static void Delete(int id)
        {
            DbContext Db = new DbContext();
            string sql = $"DELETE FROM T_Client WHERE ClientID={id}";
            Db.ExecuteNonQuery(sql);
            Db.Close();
        }
    }
}
