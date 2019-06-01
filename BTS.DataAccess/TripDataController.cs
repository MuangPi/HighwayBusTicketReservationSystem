using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
    public class TripDataController:DataControlBase
    {
        public string Insert(string tripID, string tripCode, DateTime tripDate, string timeID, string routeID, string driver1ID, string driver2ID, string busID, decimal price)
        {
            command = new SqlCommand("Trip_Insert", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@TripCode", SqlDbType.VarChar).Value = tripCode;
            command.Parameters.Add("@TripDate", SqlDbType.DateTime).Value = tripDate;
            command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;
            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@Driver1ID", SqlDbType.Char).Value = driver1ID;
            command.Parameters.Add("@Driver2ID", SqlDbType.Char).Value = driver2ID;
            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();
        }

        public string SelectTotalSeat(string busID)
        {
            command = new SqlCommand("Trip_SelectTotalSeat", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();
            
        }

        public void UpdateByTripID(string tripID, string tripCode, DateTime tripDate, string timeID, string routeID, string driver1ID, string driver2ID, string busID, decimal price)
        {
            command = new SqlCommand("Trip_UpdateByTripID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;
            command.Parameters.Add("@TripCode", SqlDbType.VarChar).Value = tripCode;
            command.Parameters.Add("@TripDate", SqlDbType.DateTime).Value = tripDate;
            command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;
            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@Driver1ID", SqlDbType.Char).Value = driver1ID;
            command.Parameters.Add("@Driver2ID", SqlDbType.Char).Value = driver2ID;
            command.Parameters.Add("@BusID", SqlDbType.Char).Value = busID;
            command.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByTripID(string tripID)
        {
            command = new SqlCommand("Trip_DeleteByTripID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("Trip_SelectList", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectByTripID(string tripID)
        {
            command = new SqlCommand("Trip_SelectByTripID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectDateByRouteID(string routeID)
        {
            command = new SqlCommand("Trip_SelectDateByRouteID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectTime(string routeID, DateTime date)
        {
            command = new SqlCommand("Trip_SelectTimeByDate", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectBusTripID(string routeID, DateTime date, string timeID)
        {
            command = new SqlCommand("Trip_SelectBusByTripID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@TimeID", SqlDbType.Char).Value = timeID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void PostByTripID(string tripID)
        {
            command = new SqlCommand("Trip_PostByTripID", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@TripID", SqlDbType.Char).Value = tripID;

            command.ExecuteNonQuery();
        }

        public string SelectInfoByTripID(string routeName, DateTime tripDate, string time)
        {
            command = new SqlCommand("Trip_SelectTripIDForCancel", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteName", SqlDbType.Char).Value = routeName;
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = tripDate;
            command.Parameters.Add("@Time", SqlDbType.VarChar).Value = time;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();

        }

        public IDataReader SelectListRecord()
        {
            command = new SqlCommand("TripRecord_SelectList", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DataTable SelectListByTripCode(string fromTripCode, string toTripCode)
        {
            command = new SqlCommand("Trip_SelectListByTripCode", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FromTripCode", SqlDbType.VarChar).Value = fromTripCode;
            command.Parameters.Add("@ToTripCode", SqlDbType.VarChar).Value = toTripCode;

            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }

        public DataTable SelectListByRouteName(string routeName)
        {
            command = new SqlCommand("Trip_SelectListByRouteName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteName", SqlDbType.VarChar).Value = routeName;


            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }

        public DataTable SelectListByBusNo(string busNo)
        {
            command = new SqlCommand("Trip_SelectListByBusNo", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@BusNo", SqlDbType.VarChar).Value = busNo;


            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }

        public DataTable SelectListByTripDate(string fromTripDate, string toTripDate)
        {
            command = new SqlCommand("Trip_SelectListByTripDate", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@FromTripDate", SqlDbType.DateTime).Value = Convert.ToDateTime(fromTripDate);
            command.Parameters.Add("@ToTripDate", SqlDbType.DateTime).Value = Convert.ToDateTime(toTripDate);

            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }
        
        public DataTable SelectListByDriverID(string driverid)
        {
            command = new SqlCommand("Trip_SelectListByDriverID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@DriverID", SqlDbType.VarChar).Value = driverid;

            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }
    }
}
