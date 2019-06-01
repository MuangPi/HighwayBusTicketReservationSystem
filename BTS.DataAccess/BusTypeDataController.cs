using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//for CommandType
using System.Data.SqlClient;//for SqlCommand


namespace BTS.DataAccess
{
   public class BusTypeDataController:DataControlBase
    {
        public void Insert(string busTypeID, string busTypeCode,string description, int totalSeats)
        {
            command = new SqlCommand("BusType_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusTypeID", SqlDbType.Char).Value = busTypeID;
            command.Parameters.Add("@BusTypeCode", SqlDbType.VarChar).Value = busTypeCode;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@TotalSeats", SqlDbType.Int).Value = totalSeats;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
           
        }

        public void UpdateByBusTypeID(string busTypeID, string busTypeCode,string description, int totalSeats)
        {
            command = new SqlCommand("BusType_UpdateByBusTypeID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusTypeID", SqlDbType.Char).Value = busTypeID;
            command.Parameters.Add("@BusTypeCode", SqlDbType.VarChar).Value = busTypeCode;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;
            command.Parameters.Add("@TotalSeats", SqlDbType.Int).Value = totalSeats;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByBusTypeID(string busTypeID)
        {
            command = new SqlCommand("BusType_DeleteByBusTypeID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusTypeID", SqlDbType.Char).Value = busTypeID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("BusType_SelectList", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectByBusTypeID(string busTypeID)
        {
            command = new SqlCommand("BusType_SelectByBusTypeID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusTypeID", SqlDbType.Char).Value = busTypeID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
