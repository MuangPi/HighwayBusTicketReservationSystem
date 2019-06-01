using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
   public class UserLevelDataController:DataControlBase
    {
        //SqlConnection connection;
        //SqlCommand command;

        //public UserLevelDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string userLevelID, string userLevelCode, string userLevel)
        {
            command = new SqlCommand("UserLevel_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserLevelID", SqlDbType.Char).Value = userLevelID;
            command.Parameters.Add("@UserLevelCode", SqlDbType.VarChar).Value = userLevelCode;
            command.Parameters.Add("@UserLevel", SqlDbType.VarChar).Value = userLevel;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateByUserLevelID(string userLevelID, string userLevelCode, string userLevel)
        {
            command = new SqlCommand("UserLevel_UpdateByUserLevelID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserLevelID", SqlDbType.Char).Value = userLevelID;
            command.Parameters.Add("@UserLevelCode", SqlDbType.VarChar).Value = userLevelCode;
            command.Parameters.Add("@UserLevel", SqlDbType.VarChar).Value = userLevel;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByUserLevelID(string userLevelID)
        {
            command = new SqlCommand("UserLevel_DeleteByUserLevelID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserLevelID", SqlDbType.Char).Value = userLevelID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("UserLevel_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
