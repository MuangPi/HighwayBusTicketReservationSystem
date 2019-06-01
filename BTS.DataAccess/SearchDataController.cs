using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
    public class SearchDataController:DataControlBase
    {
           public IDataReader SelectByCustomerName(string customerName)
            {
                command = new SqlCommand("Sale_Search", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customerName;

                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }

           public IDataReader SelectByCustomer(string customer)
            {
                command = new SqlCommand("Booking_Search", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customer;

                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }

           public IDataReader SelectByTripDate(DateTime date)
            {
                command = new SqlCommand("Booking_SearchDate", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@TripDate", SqlDbType.DateTime).Value = date;

                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }

           public DataTable SelectBySaleNo(string saleNo)
            {
                command = new SqlCommand("Sale_SelectSaleNo", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@SaleNo", SqlDbType.VarChar).Value = saleNo;


                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = command;

                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                return dt;
            }
    }
    
}
