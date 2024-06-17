using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class Cities
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CityCode { get; set; }
        public DateTime AddDate { get; set; }

        public static List<Cities> GetAll()
        {
            return CitiesDAL.GetAll();
        }

        public static Cities GetById(int id)
        {
            return CitiesDAL.GetById(id);
        }

        public static void Save(Cities city)
        {
            CitiesDAL.Save(city);
        }

        public static void Delete(int cityID)
        {
            CitiesDAL.Delete(cityID);
        }
    }
}
