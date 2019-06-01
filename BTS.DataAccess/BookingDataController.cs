using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTS.DataAccess
{
  public  class BookingDataController:DataControlBase
    {
        public string BookingInsert(string bookingID, string bookingNo, DateTime bookingDate, int quantity, string customerID)
        {
            command = new SqlCommand("Booking_Insert", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;
            command.Parameters.Add("@BookingNo", SqlDbType.VarChar).Value = bookingNo;
            command.Parameters.Add("@BookingDate", SqlDbType.DateTime).Value = bookingDate;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();
        }

        public void BookingUpdate(string bookingID, string bookingNo, DateTime bookingDate, int quantity, string customerID)
        {
            command = new SqlCommand("Booking_UpdateByBookingID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;
            command.Parameters.Add("@BookingNo", SqlDbType.VarChar).Value = bookingNo;
            command.Parameters.Add("@BookingDate", SqlDbType.DateTime).Value = bookingDate;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }


        public string AutogenerateCode(string code)
        {
            command = new SqlCommand("AutogenerateCode", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CodeDescription", SqlDbType.VarChar).Value = code;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();
        }

        public void AutogenerateReduce(string code)
        {
            command = new SqlCommand("AutogenerateReduce", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CodeDescription", SqlDbType.VarChar).Value = code;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void BookingDelete(string bookingID)
        {
            command = new SqlCommand("Booking_DeleteByBookingID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Confirm(string bookingID, string autoCode)
        {
            command = new SqlCommand("Booking_Confirm", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BookingID", SqlDbType.Char).Value = bookingID;
            command.Parameters.Add("@AutoCode", SqlDbType.Char).Value = autoCode;


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
