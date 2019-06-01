using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
   public class DriverDataController:DataControlBase
    {
        //SqlConnection connection;
        //SqlCommand command;

        //public DriverDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string driverID,string driverCode, string driverName, string driverLicence,string nrcNo, string phoneNo, string address)
        {
            command = new SqlCommand("Driver_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DriverID", SqlDbType.Char).Value = driverID;
            command.Parameters.Add("@DriverCode", SqlDbType.VarChar).Value = driverCode;
            command.Parameters.Add("@DriverName", SqlDbType.VarChar).Value = driverName;
            command.Parameters.Add("@DriverLicence", SqlDbType.VarChar).Value = driverLicence;
            command.Parameters.Add("@NRCNo", SqlDbType.VarChar).Value = nrcNo;
            command.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = phoneNo;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

       public void UpdateByDriverID(string driverID, string driverCode, string driverName, string driverLicence, string nrcNo, string phoneNo, string address)
        {
            command = new SqlCommand("Driver_UpdateByDriverID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DriverID", SqlDbType.Char).Value = driverID;
            command.Parameters.Add("@DriverCode", SqlDbType.VarChar).Value = driverCode;
            command.Parameters.Add("@DriverName", SqlDbType.VarChar).Value = driverName;
            command.Parameters.Add("@DriverLicence", SqlDbType.VarChar).Value = driverLicence;
            command.Parameters.Add("@NRCNo", SqlDbType.VarChar).Value = nrcNo;
            command.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = phoneNo;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByDriverID(string driverID)
        {
            command = new SqlCommand("Driver_DeleteByDriverID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DriverID", SqlDbType.Char).Value = driverID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("Driver_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
