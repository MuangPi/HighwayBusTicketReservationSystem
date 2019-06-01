using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTS.DataAccess
{
   public class SaleDataController:DataControlBase
    {
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

        public string SaleInsert(string saleID, string saleNo, DateTime saleDate, int quantity, string customerID)
        {
            command = new SqlCommand("Sale_Insert", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;
            command.Parameters.Add("@SaleNo", SqlDbType.VarChar).Value = saleNo;
            command.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = saleDate;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();

        }

        public void SaleUpdate(string saleID, string saleNo, DateTime saleDate, int quantity, string customerID)
        {
            command = new SqlCommand("Sale_UpdateBySaleID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;
            command.Parameters.Add("@SaleNo", SqlDbType.VarChar).Value = saleNo;
            command.Parameters.Add("@SaleDate", SqlDbType.DateTime).Value = saleDate;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }

        public void SaleDelete(string saleID)
        {
            command = new SqlCommand("Sale_DeleteBySaleID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@SaleID", SqlDbType.Char).Value = saleID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
       {
           command = new SqlCommand("SaleRecord_SelectList", connection);
           command.CommandType = CommandType.StoredProcedure;
           connection.Open();
           return command.ExecuteReader(CommandBehavior.CloseConnection);

       }

       #region ForReports
       public DataTable SelectMonthlySummary(string month, string year)
       {
           command = new SqlCommand("Sale_MonthlySummary", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@Month", SqlDbType.VarChar).Value = month;
           command.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectMonthlyDetail(string month, string year)
       {
           command = new SqlCommand("Sale_MonthlyDetail", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@Month", SqlDbType.VarChar).Value = month;
           command.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectYearlySummary(string year)
       {
           command = new SqlCommand("Sale_YearlySummary", connection);
           command.CommandType = CommandType.StoredProcedure;

           
           command.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectYearlyDetail(string year)
       {
           command = new SqlCommand("Sale_YearlyDetail", connection);
           command.CommandType = CommandType.StoredProcedure;

          
           command.Parameters.Add("@Year", SqlDbType.VarChar).Value = year;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }


       public DataTable SelectSummaryBySaleNo(string fromSaleNo, string toSaleNo)
       {
           command = new SqlCommand("Sale_SummaryBySaleNo", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleNo", SqlDbType.VarChar).Value = fromSaleNo;
           command.Parameters.Add("@ToSaleNo", SqlDbType.VarChar).Value = toSaleNo;

           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectDetailBySaleNo(string fromSaleNo, string toSaleNo)
       {
           command = new SqlCommand("Sale_DetailBySaleNo", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleNo", SqlDbType.VarChar).Value = fromSaleNo;
           command.Parameters.Add("@ToSaleNo", SqlDbType.VarChar).Value = toSaleNo;

           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectSummaryByTripOne(string routeName, DateTime date, string time)
       {
           command = new SqlCommand("Sale_SummaryByTripOne", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@RouteName", SqlDbType.VarChar).Value = routeName;
           command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
           command.Parameters.Add("@Time", SqlDbType.VarChar).Value = time;

           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectDetailByTripOne(string routeName, DateTime date, string time)
       {
           command = new SqlCommand("Sale_DetailByTripOne", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@RouteName", SqlDbType.VarChar).Value = routeName;
           command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
           command.Parameters.Add("@Time", SqlDbType.VarChar).Value = time;

           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectSummaryBySaleDate(string fromSaleDate, string toSaleDate)
       {

           command = new SqlCommand("Sale_SummaryBySaleDate", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleDate", SqlDbType.DateTime).Value = Convert.ToDateTime(fromSaleDate);
           command.Parameters.Add("@ToSaleDate", SqlDbType.DateTime).Value = Convert.ToDateTime(toSaleDate);


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectDetailBySaleDate(string fromSaleDate, string toSaleDate)
       {

           command = new SqlCommand("Sale_DetailBySaleDate", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleDate", SqlDbType.DateTime).Value =Convert.ToDateTime(fromSaleDate);
           command.Parameters.Add("@ToSaleDate", SqlDbType.DateTime).Value = Convert.ToDateTime(toSaleDate);


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public DataTable SelectSummaryByTripCode(string fromTripCode, string toTripCode)
       {
           command = new SqlCommand("Sale_SummaryByTripCode", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromTripCode", SqlDbType.VarChar).Value = fromTripCode;
           command.Parameters.Add("@TotripCode", SqlDbType.VarChar).Value = toTripCode;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }


       public DataTable SelectDetailByTripCode(string fromTripCode, string toTripCode)
       {
           command = new SqlCommand("Sale_DetailByTripCode", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromTripCode", SqlDbType.VarChar).Value = fromTripCode;
           command.Parameters.Add("@TotripCode", SqlDbType.VarChar).Value = toTripCode;


           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;

           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }

       public void PostBySaleNo(string fromSaleNo, string toSaleNo)
       {
           command = new SqlCommand("Sale_PostBySaleNo", connection, transaction);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleNo", SqlDbType.VarChar).Value = fromSaleNo;
           command.Parameters.Add("@ToSaleNo", SqlDbType.VarChar).Value = toSaleNo;

           command.ExecuteNonQuery();
       }

       public void PostBySaleDate(DateTime fromSaleDate, DateTime toSaleDate)
       {
           command = new SqlCommand("Sale_PostBySaleDate", connection, transaction);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@FromSaleDate", SqlDbType.DateTime).Value = fromSaleDate;
           command.Parameters.Add("@ToSaleDate", SqlDbType.DateTime).Value =toSaleDate;

           command.ExecuteNonQuery();
       }

       public DataTable DailyReport(string date)
       {
           command = new SqlCommand("Sale_Daily", connection);
           command.CommandType = CommandType.StoredProcedure;

           command.Parameters.Add("@TripDate", SqlDbType.DateTime).Value = Convert.ToDateTime(date);

           SqlDataAdapter Adapter = new SqlDataAdapter();
           Adapter.SelectCommand = command;
           DataTable dt = new DataTable();
           Adapter.Fill(dt);
           return dt;
       }
       #endregion

   }
}
