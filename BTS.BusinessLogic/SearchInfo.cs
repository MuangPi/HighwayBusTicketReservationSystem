using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
    public class SearchInfo
    {
        private string saleID;
        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        private string saleNo;
        public string SaleNo
        {
            get { return saleNo; }
            set { saleNo = value; }
        }

        private DateTime saleDate;
        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }

        private string bookingID;
        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        private string bookingNo;
        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private DateTime bookingDate;
        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }

        private string saleDetailID;
        public string SaleDetailID
        {
            get { return saleDetailID; }
            set { saleDetailID = value; }
        }

        private string bookindDetailID;
        public string BookingDetailID
        {
            get { return bookindDetailID; }
            set { bookindDetailID = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

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

        private string tripID;
        public string TripID
        {
            get { return tripID; }
            set { tripID = value; }
        }

        private string seatNo;
        public string SeatNo
        {
            get { return seatNo; }
            set { seatNo = value; }
        }

        private string routeID;
        public string RouteID
        {
            get { return routeID; }
            set { routeID = value; }
        }

        private string routeName;
        public string RouteName
        {
            get { return routeName; }
            set { routeName = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string timeID;
        public string TimeID
        {
            get { return timeID; }
            set { timeID = value; }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string busID;
        public string BusID
        {
            get { return busID; }
            set { busID = value; }
        }

        private string busNo;
        public string BusNo
        {
            get { return busNo; }
            set { busNo = value; }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private decimal totalamount;
        public decimal TotalAmount
        {
            get { return totalamount; }
            set { totalamount = value; }
        }
    }

    public class SearchCollection : Collection<SearchInfo> { }

    public class SearchController
    {
        SearchDataController DataAccess;

        public SearchController()
        {
            DataAccess = new SearchDataController();
        }

        public SearchCollection SelectByCustomerName(string customerName)
        {
            SearchCollection searchCollection = new SearchCollection();
            IDataReader Reader = DataAccess.SelectByCustomerName(customerName);

            while (Reader.Read())
            {
                SearchInfo searchInfo = new SearchInfo();
                
                searchInfo.SaleID = Convert.ToString(Reader["SaleID"]);
                searchInfo.SaleNo = Convert.ToString(Reader["SaleNo"]);
                searchInfo.SaleDate = Convert.ToDateTime(Reader["SaleDate"]);
                searchInfo.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchInfo.CustomerID = Convert.ToString(Reader["CustomerID"]);
                searchInfo.Gender = Convert.ToString(Reader["Gender"]);
                searchInfo.CustomerName = Convert.ToString(Reader["CustomerName"]);
                searchInfo.NRCNo = Convert.ToString(Reader["NRCNo"]);
                searchInfo.PhoneNo = Convert.ToString(Reader["PhoneNo"]);
                searchInfo.TripID = Convert.ToString(Reader["TripID"]);
                searchInfo.SaleDetailID = Convert.ToString(Reader["SaleDetailID"]);
                searchInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
                searchInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                searchInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                searchInfo.Date = Convert.ToDateTime(Reader["Date"]);
                searchInfo.TimeID = Convert.ToString(Reader["TimeID"]);
                searchInfo.Time = Convert.ToString(Reader["Time"]);
                searchInfo.BusID = Convert.ToString(Reader["BusID"]);
                searchInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                searchInfo.Price = Convert.ToDecimal(Reader["Price"]);

                searchCollection.Add(searchInfo);
            }
            Reader.Close();
            return searchCollection;
        }

        public SearchCollection SelectByCustomer(string customer)
        {
            SearchCollection searchCollection = new SearchCollection();
            IDataReader Reader = DataAccess.SelectByCustomer(customer);

            while (Reader.Read())
            {
                SearchInfo searchInfo = new SearchInfo();
               
                searchInfo.BookingID = Convert.ToString(Reader["BookingID"]);
                searchInfo.BookingNo = Convert.ToString(Reader["BookingNo"]);
                searchInfo.BookingDetailID = Convert.ToString(Reader["BookingDetailID"]);
                searchInfo.BookingDate = Convert.ToDateTime(Reader["BookingDate"]);
                searchInfo.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchInfo.CustomerID = Convert.ToString(Reader["CustomerID"]);
                searchInfo.Gender = Convert.ToString(Reader["Gender"]);
                searchInfo.CustomerName = Convert.ToString(Reader["CustomerName"]);
                searchInfo.NRCNo = Convert.ToString(Reader["NRCNo"]);
                searchInfo.PhoneNo = Convert.ToString(Reader["PhoneNo"]);
                searchInfo.TripID = Convert.ToString(Reader["TripID"]);
                searchInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
                searchInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                searchInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                searchInfo.Date = Convert.ToDateTime(Reader["Date"]);
                searchInfo.TimeID = Convert.ToString(Reader["TimeID"]);
                searchInfo.Time = Convert.ToString(Reader["Time"]);
                searchInfo.BusID = Convert.ToString(Reader["BusID"]);
                searchInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                searchInfo.Price = Convert.ToDecimal(Reader["Price"]);               

                searchCollection.Add(searchInfo);
            }
            Reader.Close();
            return searchCollection;
        }

        public SearchCollection SelectByTripDate(DateTime date)
        {
            SearchCollection searchCollection = new SearchCollection();
            IDataReader Reader = DataAccess.SelectByTripDate(date);

            while (Reader.Read())
            {
                SearchInfo searchInfo = new SearchInfo();

                searchInfo.BookingID = Convert.ToString(Reader["BookingID"]);
                searchInfo.BookingNo = Convert.ToString(Reader["BookingNo"]);
                searchInfo.BookingDetailID = Convert.ToString(Reader["BookingDetailID"]);
                searchInfo.BookingDate = Convert.ToDateTime(Reader["BookingDate"]);
                searchInfo.Quantity = Convert.ToInt32(Reader["Quantity"]);
                searchInfo.CustomerID = Convert.ToString(Reader["CustomerID"]);
                searchInfo.Gender = Convert.ToString(Reader["Gender"]);
                searchInfo.CustomerName = Convert.ToString(Reader["CustomerName"]);
                searchInfo.NRCNo = Convert.ToString(Reader["NRCNo"]);
                searchInfo.PhoneNo = Convert.ToString(Reader["PhoneNo"]);
                searchInfo.TripID = Convert.ToString(Reader["TripID"]);
                searchInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
                searchInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                searchInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                searchInfo.Date = Convert.ToDateTime(Reader["Date"]);
                searchInfo.TimeID = Convert.ToString(Reader["TimeID"]);
                searchInfo.Time = Convert.ToString(Reader["Time"]);
                searchInfo.BusID = Convert.ToString(Reader["BusID"]);
                searchInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                searchInfo.Price = Convert.ToDecimal(Reader["Price"]);

                searchCollection.Add(searchInfo);
            }

            Reader.Close();
            return searchCollection;
        }

        public DataTable SelectBySaleNo(string saleNo)
        {
            return DataAccess.SelectBySaleNo(saleNo);
        }
    }
}
