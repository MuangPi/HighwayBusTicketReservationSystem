using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//for SqlCommand
using System.Data;//for CommandType
using System.Configuration;//for ConfigurationManager


namespace BTS.DataAccess
{
   public class UserDataController:DataControlBase
    {
        //SqlCommand command;
        //SqlConnection connection;

        //public UserDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string userID, string name, string userName, string password, string userLevelID)
        {
            command = new SqlCommand("UserAndPassword_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@UserLevelID", SqlDbType.Char).Value = userLevelID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(string userID, string name, string userName, string password, string userLevelID)
        {
            command = new SqlCommand("UserAndPassword_UpdateByUserID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@UserLevelID", SqlDbType.Char).Value = userLevelID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByUserID(string userID)
        {
            command = new SqlCommand("UserAndPassword_DeleteByUserID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()// interface
        {
            command = new SqlCommand("UserAndPassword_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectByUserID(string userID)
        {
            command = new SqlCommand("UserAndPassword_SelectByUserID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string CheckUserNameAndPassword(string userName, string password)
        {
            object result;
            string str = "";

            command = new SqlCommand("UserAndPassword_SelectByUserName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

            connection.Open();
            result = command.ExecuteScalar();

            if (result != null)
                str = result.ToString();
            connection.Close();

            return str.ToString();
        }
    }
}
