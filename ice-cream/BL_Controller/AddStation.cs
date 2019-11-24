using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
/*
 * @Author Ehab Fadl
 * 
 * */
namespace ice_cream.BL_Controller
   
{
    class AddStation
    {





        // Funktion to Add new Station
        public void AddNewStation(String station_ID,string date, int target, int actual, int variance) {
            DAL_Model.DataAccessLayer DAL_Model = new DAL_Model.DataAccessLayer();
            DAL_Model.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@STATION_ID",SqlDbType.NChar,50);
            param[0].Value = station_ID;
            param[1] = new SqlParameter("@DATE", SqlDbType.NChar,50);
            param[1].Value = date;
            param[2] = new SqlParameter("@TARGET", SqlDbType.Int);
            param[2].Value = target;
            param[3] = new SqlParameter("@ACTUAL", SqlDbType.Int);
            param[3].Value = actual;
            param[4] = new SqlParameter("@VARIANCE", SqlDbType.Int);
            param[4].Value = variance;
            DAL_Model.ExcuteCommand("ADD_NEW_STATION",param);
            DAL_Model.Close();
        }









        //Funktion to Verify to StationID 
        public DataTable VerifyStationID(String station_ID)
        {
            DAL_Model.DataAccessLayer DAL_Model = new DAL_Model.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@STATION_ID", SqlDbType.NChar, 50);
            param[0].Value = station_ID;
            dt=DAL_Model.SelectData("VERIFY_STATION_ID", param);
            DAL_Model.Close();
            return dt;
        }




    }
}
