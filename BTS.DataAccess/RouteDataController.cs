using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTS.DataAccess
{
   public class RouteDataController:DataControlBase
    {
        //SqlConnection connection;
        //SqlCommand command;

        //public RouteDataController()
        //{
        //    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        //}

        public void Insert(string routeID, string routeCode, string routeName, string fromLocationID, string toLocationID)
        {
            command = new SqlCommand("Route_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@RouteCode", SqlDbType.VarChar).Value = routeCode;
            command.Parameters.Add("@RouteName", SqlDbType.VarChar).Value = routeName;
            command.Parameters.Add("@FromLocationID", SqlDbType.Char).Value = fromLocationID;
            command.Parameters.Add("@ToLocationID", SqlDbType.Char).Value = toLocationID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateByRouteID(string routeID, string routeCode, string routeName, string fromLocationID, string toLocationID)
        {
            command = new SqlCommand("Route_UpdateByRouteID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;
            command.Parameters.Add("@RouteCode", SqlDbType.VarChar).Value = routeCode;
            command.Parameters.Add("@RouteName", SqlDbType.VarChar).Value = routeName;
            command.Parameters.Add("@FromLocationID", SqlDbType.Char).Value = fromLocationID;
            command.Parameters.Add("@ToLocationID", SqlDbType.Char).Value = toLocationID;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteByRouteID(string routeID)
        {
            command = new SqlCommand("Route_DeleteByRouteID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public IDataReader SelectList()
        {
            command = new SqlCommand("Route_SelectList", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IDataReader SelectByRouteID(string routeID)
        {
            command = new SqlCommand("Route_SelectByRouteID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@RouteID", SqlDbType.Char).Value = routeID;

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
