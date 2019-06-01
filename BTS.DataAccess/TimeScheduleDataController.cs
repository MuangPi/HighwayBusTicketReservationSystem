using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BTS.DataAccess
{
   public class TimeScheduleDataController:DataControlBase
    {
       // SqlConnection connection;
       // SqlCommand command;

       //public TimeScheduleDataController()
       //{
       //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
       //}

       public void Insert(string timeID, string time, string description)
       {
           command = new SqlCommand("Time_Insert", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;
           command.Parameters.Add("@Time", SqlDbType.VarChar).Value = time;
           command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;

           connection.Open();
           command.ExecuteNonQuery();
           connection.Close(); 
       }

       public void UpdateByTimeID(string timeID, string time, string description)
       {
           command = new SqlCommand("Time_UpdateByTimeID", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;
           command.Parameters.Add("@Time", SqlDbType.VarChar).Value = time;
           command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;

           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
       }

       public void DeleteByTimeID(string timeID)
       {
           command = new SqlCommand("Time_DeleteByTimeID", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;

           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
       }

       public IDataReader SelectList()
       {
           command = new SqlCommand("Time_SelectList", connection);
           command.CommandType = CommandType.StoredProcedure;

           connection.Open();
           return command.ExecuteReader(CommandBehavior.CloseConnection);
       }
    }
}
