using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
   public class TripDetailDataController:DataControlBase
    {
       public void InsertDetail(string tripDetailID, string tripID, string seatNo, string status)
       {
           command = new SqlCommand("TripDetail_Insert", connection, transaction);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TripDetailID", SqlDbType.Char).Value = tripDetailID;
           command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
           command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;
           command.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;
           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
       }

       public void DeleteDetailByTripID(string tripID)
       {
           command = new SqlCommand("TripDetail_DeleteByTripID", connection, transaction);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
       }

       public IDataReader SelectDetailByTripID(string tripID)
       {
           command = new SqlCommand("TripDetail_SelectByTripID", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

           connection.Open();
           return command.ExecuteReader(CommandBehavior.CloseConnection);
       }

       public void UpdateStatusByTripID(string tripID, string seatNo, string status)
       {
           command = new SqlCommand("TripDetail_UpdateByTripID", connection, transaction);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
           command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;
           command.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;

           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
       }

    }
}
