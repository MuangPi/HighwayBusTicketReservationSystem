using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class CustomerInfo
    {
        private string customerID;
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string nrcNo;
        public string NRCNo
        {
            get { return nrcNo; }
            set { nrcNo = value; }
        }

        private string phoneNo;
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
    }

    public class CustomerCollection : Collection<CustomerInfo> { }

    public class CustomerController
    {
        CustomerDataController DataAccess;

        public CustomerController()
        {
            DataAccess = new CustomerDataController();
        }

        public void CustomerInsert(CustomerInfo customerInfo)
        {
            DataAccess.CustomerInsert(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);
        }

        public void CustomerUpdate(CustomerInfo customerInfo)
        {
            DataAccess.CustomerUpdate(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);
        }

        public DataTable CustomerSearchByName(string customerName)
        {
            DataTable dt = DataAccess.CustomerSearchByName(customerName);
            return dt;
        }
    }
}
