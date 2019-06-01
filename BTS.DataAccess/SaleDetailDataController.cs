using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTS.DataAccess
{
   public class SaleDetailDataController:DataControlBase
    {
        public void SaleDetailInsert(string saleDetailID, string saleID, string tripID, string seatNo)
        {
            command = new SqlCommand("SaleDetail_Insert", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SaleDetailID", SqlDbType.Char).Value = saleDetailID;
            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;
            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void SaleDetailUpdate(string saleDetailID, string saleID, string tripID, string seatNo)
        {
            command = new SqlCommand("SaleDetail_UpdateBySaleID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SaleDetailID", SqlDbType.Char).Value = saleDetailID;
            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;
            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SeatNo", SqlDbType.VarChar).Value = seatNo;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectSaleDetail(string tripID, string saleID)//for seatno available 
        {
            command = new SqlCommand("SaleDetail_SelectBySeatNo", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void SaleDetailDeleteSaleID(string tripID, string saleID)
        {
            command = new SqlCommand("SaleDetail_DeleteBySaleID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
