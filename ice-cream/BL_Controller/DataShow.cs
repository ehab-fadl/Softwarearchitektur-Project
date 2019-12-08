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
    class DataShow
    {
       
        
        
        
        //Fanction to connect with Database and select Data
        public DataTable Datashow()
        {
            DAL_Model.DataAccessLayer DAL_Model = new ice_cream.DAL_Model.DataAccessLayer();
            DAL_Model.Open();
            DataTable dt = new DataTable();
            dt = DAL_Model.SelectData("DATA_SHOW",null);
            return dt;
        }



    }
}
