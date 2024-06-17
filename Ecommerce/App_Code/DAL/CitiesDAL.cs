using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class CitiesDAL
    {
        public static List<Cities> GetAll()
        {
            DbContext Db = new DbContext();
            string Sql = "Select * from T_City";
            DataTable Dt = Db.Execute(Sql);
            List<Cities> CityList = new List<Cities>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Cities t = new Cities()
                {
                    CityID = int.Parse(Dt.Rows[i]["CityID"] + ""),
                    CityName = Dt.Rows[i]["CityName"] + "",
                    CityCode = int.Parse(Dt.Rows[i]["CityCode"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                CityList.Add(t);
            }
            Db.Close();
            return CityList;
        }
        public static Cities GetById(int Id)
        {
            DbContext Db = new DbContext();
            string Sql = $"Select * from T_City where CityID={Id}";
            DataTable Dt = Db.Execute(Sql);
            Cities Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Cities()
                {

                    CityID = int.Parse(Dt.Rows[0]["CityID"] + ""),
                    CityName = Dt.Rows[0]["CityName"] + "",
                    CityCode = int.Parse(Dt.Rows[0]["CityCode"] + ""),
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return Tmp;
        }
        public static Cities Save(Cities city)
        {
            string sql = "";
            if (city.CityID == -1)
            {
                sql = "insert into T_City (CityName,CityCode) values ";
                sql += $"(N'{city.CityName}',{city.CityCode})";
            }
            else
            {
                sql = "update T_City set ";
                sql += $" CityName =N'{city.CityName}',";
                sql += $" CityCode ={city.CityCode}";
                sql += $"where CityID={city.CityID}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(sql);
            GetAll();
            return city;
        }

        public static void Delete(int CityID)
        {
            DbContext Db = new DbContext();
            string Sql = "Delete from T_City where CityID=" + CityID;
            Db.ExecuteNonQuery(Sql);
            Db.Close();
        }
    }
}
