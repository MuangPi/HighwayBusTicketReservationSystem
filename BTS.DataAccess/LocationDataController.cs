using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Configuration;

namespace BTS.DataAccess
{
    public class LocationDataController:DataControlBase
    {
        //SqlConnection connection;
        //SqlCommand command;

        //public LocationDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string locationID, string locationCode, string locationName)
        {
            command = new SqlCommand("Location_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@LocationID", SqlDbType.Char).Value = locationID;
            command.Parameters.Add("@LocationCode", SqlDbType.VarChar).Value = locationCode;
            command.Parameters.Add("@LocationName", SqlDbType.VarChar).Value = locationName;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateByLocationID(string locationID, string locationCode,string locationName)
        {
            command = new SqlCommand("Location_UpdateByLocationID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("LocationID", SqlDbType.Char).Value = locationID;
            command.Parameters.Add("LocationCode", SqlDbType.VarChar).Value = locationCode;
            command.Parameters.Add("LocationName", SqlDbType.VarChar).Value = locationName;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByLocationID(string locationID)
        {
            command = new SqlCommand("Location_DeleteByLocationID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("LocationID", SqlDbType.Char).Value = locationID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("Location_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

