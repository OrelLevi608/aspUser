using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class CategoryDAL
    {
        public static List<Category> GetAll()
        {
            DbContext Db = new DbContext();
            string Sql = "Select * from T_Category";
            DataTable Dt = Db.Execute(Sql);
            List<Category> CategoryList = new List<Category>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Category t = new Category()
                {
                    Cid = int.Parse(Dt.Rows[i]["Cid"] + ""),
                    Cname = Dt.Rows[i]["Cname"] + "",
                    Cdesc = Dt.Rows[i]["Cdesc"] + "",
                    Picname = Dt.Rows[i]["Picname"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[i]["AddDate"] + "")
                };
                CategoryList.Add(t);
            }
            Db.Close();
            return CategoryList;
        }
        public static Category GetById(int Id)
        {
            DbContext Db = new DbContext();
            string Sql = $"Select * from T_Category where Cid={Id}";
            DataTable Dt = Db.Execute(Sql);
            Category Tmp = null;
            if (Dt.Rows.Count > 0)
            {
                Tmp = new Category()
                {
                    Cid = int.Parse(Dt.Rows[0]["Cid"] + ""),
                    Cname = Dt.Rows[0]["Cname"] + "",
                    Cdesc = Dt.Rows[0]["Cdesc"] + "",
                    Picname = Dt.Rows[0]["Picname"] + "",
                    AddDate = DateTime.Parse(Dt.Rows[0]["AddDate"] + "")
                };
            }
            Db.Close();
            return Tmp;
        }
        public static void Save(Category category)
        {
            string sql = "";
            if (category.Cid == -1)
            {
                sql = "insert into T_Category (Cname,Cdesc,Picname) values ";
                sql += $"(N'{category.Cname}',N'{category.Cdesc}',N'{category.Picname}')";
            }
            else
            {
                sql = "update T_Category set ";
                sql += $" Cname=N'{category.Cname}',";
                sql += $" Cdesc=N'{category.Cdesc}',";
                sql += $" Picname=N'{category.Picname}'";
                sql += $" where Cid={category.Cid}";
            }
            DbContext Db = new DbContext();
            Db.ExecuteNonQuery(sql);
        }

        public static void Delete(int Cid)
        {
            DbContext Db = new DbContext();
            string Sql = $"Delete from T_Category where Cid={Cid}";
            Db.ExecuteNonQuery(Sql);
            Db.Close();
        }
    }
}
