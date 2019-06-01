using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BTS.DataAccess
{
    public class BusDataController:DataControlBase
    {
        //SqlConnection connection;
        //SqlCommand command;

        //public BusDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string busID, string busCode, string busNo, string busTypeID)
        {
            command = new SqlCommand("Bus_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;
            command.Parameters.Add("@BusCode", SqlDbType.VarChar).Value = busCode;
            command.Parameters.Add("@BusNo", SqlDbType.VarChar).Value = busNo;
            command.Parameters.Add("@BusTypeID", SqlDbType.VarChar).Value = busTypeID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateByBusID(string busID, string busCode, string busNo, string busTypeID)
        {
            command = new SqlCommand("Bus_UpdateByBusID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;
            command.Parameters.Add("@BusCode", SqlDbType.VarChar).Value = busCode;
            command.Parameters.Add("@BusNo", SqlDbType.VarChar).Value = busNo;
            command.Parameters.Add("@BusTypeID", SqlDbType.VarChar).Value = busTypeID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByBusID(string busID)
        {
            command = new SqlCommand("Bus_DeleteByBusID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("Bus_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectByBusID(string busID)
        {
            command = new SqlCommand("Bus_SelectByBusID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DataTable SelectBus()
        {
            command = new SqlCommand("SelectBus", connection);
            command.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }
    }
}
