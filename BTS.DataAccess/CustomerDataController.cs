using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BTS.DataAccess
{
   public class CustomerDataController:DataControlBase
    {

        public string CustomerInsert(string customerID, string customerName, string gender, string nrcNo, string phoneNo)
        {
            command = new SqlCommand("Customer_WinInsertUpdate", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;
            command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customerName;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@NRC", SqlDbType.VarChar).Value = nrcNo;
            command.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = phoneNo;

            connection.Open();
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj.ToString();
        }

        public DataTable CustomerSearchByName(string customerName)
        {
            command = new SqlCommand("Customer_Search", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customerName;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public void CustomerUpdate(string customerID, string customerName, string gender, string nrcNo, string phoneNo)
        {
            command = new SqlCommand("Customer_WinInsertUpdate", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CustomerID", SqlDbType.Char).Value = customerID;
            command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customerName;
            command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@NRC", SqlDbType.VarChar).Value = nrcNo;
            command.Parameters.Add("@PhoneNo", SqlDbType.VarChar).Value = phoneNo;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
  
    }
}
