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

namespace ice_cream.DAL_Model
{
    class DataAccessLayer
    {

        //Connection Text between the Server and an Application
        SqlConnection sqlConnection;
        public DataAccessLayer()
        {
             sqlConnection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Assessment_Record_DB;Integrated Security=true");
        }





        //Method to open the Connection
        public void Open() {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }






        //Method to close the Connection
        public void Close() {
            if (sqlConnection.State==ConnectionState.Open) {
                sqlConnection.Close();
            }
        }
      
      




        //Method to Read Data from Database
        public DataTable SelectData (string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if(param != null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }
       






        //Method to Insert, Update, and Delete Data from Database
        public void ExcuteCommand(string stored_procedure, SqlParameter[] param) {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlConnection;
            if (param !=null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            sqlcmd.ExecuteNonQuery();

        }


    }
}
