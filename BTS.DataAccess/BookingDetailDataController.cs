using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTS.DataAccess
{
   public class BookingDetailDataController:DataControlBase
    {
        public void BookingDetailInsert(string bookingDetailID, string bookingID, string tripID, string seatNo)
        {
            command = new SqlCommand("BookingDetail_Insert", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingDetailID", SqlDbType.Char).Value = bookingDetailID;
            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;
            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void BookingDetailUpdate(string bookingDetailID, string bookingID, string tripID, string seatNo)
        {
            command = new SqlCommand("BookingDetail_UpdateByBookingID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingDetailID", SqlDbType.Char).Value = bookingDetailID;
            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;
            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader BookingDetailSeatNo(string tripID)
        {
            command = new SqlCommand("BookingDetail_SelectBySeatNo", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string BookingDetailBookingID(string tripID)
        {
            command = new SqlCommand("BookingDetail_SelectAndDeleteByTripID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();

        }

        public IDataReader SelectBookingDetail(string tripID, string bookingID)
        {
            command = new SqlCommand("BookingDetail_SelectBookingBySeatNo", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public void BookingDetailDeleteBookingID(string tripID, string bookingID)
        {
            command = new SqlCommand("BookingDetail_DeleteByTripIDAndBookingID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
