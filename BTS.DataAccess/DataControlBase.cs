using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//for ConnectionState
using System.Data.SqlClient;//SqlConnection,SqlCommand
using System.Configuration;//for ConfigurationManager

namespace BTS.DataAccess
{
   public class DataControlBase
    {
       public SqlConnection connection;
        public SqlCommand command;
        public SqlTransaction transaction;

        public DataControlBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BTS"].ConnectionString);
        }

        public void StartTransaction()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            transaction = connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (transaction != null)
            {
                transaction.Commit();
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void RollBackTransaction()
        {
            if (transaction != null)
            {
                transaction.Rollback();
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
