using System;
using System.Collections.ObjectModel;
using BTS.DataAccess;
using System.Data;

namespace BTS.BusinessLogic
{
    public class TripInfo
    {
        private string tripID;
        public string TripID
        {
            get { return tripID; }
            set { tripID = value; }
        }

        private string tripCode;
        public string TripCode
        {
            get { return tripCode; }
            set { tripCode = value; }
        }

        private DateTime tripDate;
        public DateTime TripDate
        {
            get { return tripDate; }
            set { tripDate = value; }
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


        private string driver1ID;
        public string Driver1ID
        {
            get { return driver1ID; }
            set { driver1ID = value; }
        }

        private string driver1Name;
        public string Driver1Name
        {
            get { return driver1Name; }
            set { driver1Name = value; }
        }

        private string driver2ID;
        public string Driver2ID
        {
            get { return driver2ID; }
            set { driver2ID = value; }
        }

        private string driver2Name;
        public string Driver2Name
        {
            get { return driver2Name; }
            set { driver2Name = value; }
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

        private string totalSeat;
        public string TotalSeat
        {
            get { return totalSeat; }
            set { totalSeat = value; }
        }
    }

    public class TripCollection : Collection<TripInfo> { }

    public class TripController
    {
        DataControlBase DataControlBaseDataAccess;
        TripDataController DataAccess;
        TripDetailDataController TripDetailDataAccess;

        public TripController()
        {
            DataControlBaseDataAccess = new DataControlBase();
            DataAccess = new TripDataController();
            TripDetailDataAccess = new TripDetailDataController();
        }

        public void Insert(TripInfo tripInfo, TripDetailCollection tripDetailCollection)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                string TripID = DataAccess.Insert(tripInfo.TripID, tripInfo.TripCode, tripInfo.TripDate, tripInfo.TimeID, tripInfo.RouteID, tripInfo.Driver1ID, tripInfo.Driver2ID, tripInfo.BusID, tripInfo.Price);

                foreach (TripDetailInfo tripDetailInfo in tripDetailCollection)
                {
                    TripDetailDataAccess.InsertDetail(tripDetailInfo.TripDetailID, TripID, tripDetailInfo.SeatNo, tripDetailInfo.Status);
                }
                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void UpdateByTripID(TripInfo tripInfo, TripDetailCollection tripDetailCollection)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                DataAccess.UpdateByTripID(tripInfo.TripID, tripInfo.TripCode, tripInfo.TripDate, tripInfo.TimeID, tripInfo.RouteID, tripInfo.Driver1ID, tripInfo.Driver2ID, tripInfo.BusID, tripInfo.Price);
                TripDetailDataAccess.DeleteDetailByTripID(tripInfo.TripID);

                foreach (TripDetailInfo tripDetailInfo in tripDetailCollection)
                {
                    TripDetailDataAccess.InsertDetail(tripDetailInfo.TripDetailID, tripDetailInfo.TripID, tripDetailInfo.SeatNo, tripDetailInfo.Status);
                }
                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void DeleteByTripID(string tripID)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                TripDetailDataAccess.DeleteDetailByTripID(tripID);
                DataAccess.DeleteByTripID(tripID);

                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public TripCollection SelectList()
        {
            TripCollection collection = new TripCollection();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                TripInfo tripInfo = new TripInfo();
                tripInfo.TripID = Convert.ToString(Reader["TripID"]);
                tripInfo.TripCode = Convert.ToString(Reader["TripCode"]);
                tripInfo.TripDate = Convert.ToDateTime(Reader["Date"]);
                tripInfo.TimeID = Convert.ToString(Reader["TimeID"]);
                tripInfo.Time= Convert.ToString(Reader["Time"]);
                tripInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                tripInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                tripInfo.BusID = Convert.ToString(Reader["BusID"]);
                tripInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                tripInfo.Driver1ID = Convert.ToString(Reader["Driver1ID"]);
                tripInfo.Driver1Name = Convert.ToString(Reader["DriverName"]);
                tripInfo.Driver2ID = Convert.ToString(Reader["Driver2ID"]);
                tripInfo.Driver2Name = Convert.ToString(Reader["DriverName"]);
                tripInfo.Price = Convert.ToDecimal(Reader["Price"]);
                collection.Add(tripInfo);
            }
            Reader.Close();
            return collection;
        }

        public TripInfo SelectByTripID(string tripID)
        {
            TripInfo tripInfo = new TripInfo();
            IDataReader Reader = DataAccess.SelectByTripID(tripID);

            if (Reader.Read())
            {
                tripInfo.TripID = Convert.ToString(Reader["TripID"]);
                tripInfo.TripCode = Convert.ToString(Reader["TripCode"]);
                tripInfo.TripDate = Convert.ToDateTime(Reader["Date"]);
                tripInfo.TimeID = Convert.ToString(Reader["TimeID"]);
                tripInfo.Time = Convert.ToString(Reader["Time"]);
                tripInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                tripInfo.Driver1ID = Convert.ToString(Reader["Driver1ID"]);
                tripInfo.Driver2ID = Convert.ToString(Reader["Driver2ID"]);
                tripInfo.BusID = Convert.ToString(Reader["BusID"]);
                tripInfo.Price = Convert.ToDecimal(Reader["Price"]);
            }
            Reader.Close();
            return tripInfo;
        }

        public string SelectTotalSeat(string busID)
        {
            return DataAccess.SelectTotalSeat(busID);
          
        }

        public TripCollection SelectDateByRouteID(string routeID)
        {
            TripCollection tripCollection = new TripCollection();
            IDataReader Reader = DataAccess.SelectDateByRouteID(routeID);

            while (Reader.Read())
            {
                TripInfo tripInfo = new TripInfo();
                tripInfo.TripDate = Convert.ToDateTime(Reader["Date"]);

                tripCollection.Add(tripInfo);
            }
            Reader.Close();
            return tripCollection;
        }

        public TripCollection SelectTime(string routeID, DateTime date)
        {
            TripCollection tripCollection = new TripCollection();
            IDataReader reader = DataAccess.SelectTime(routeID, date);

            while (reader.Read())
            {
                TripInfo tripInfo = new TripInfo();
                tripInfo.TimeID = Convert.ToString(reader["TimeID"]);
                tripInfo.Time = Convert.ToString(reader["Time"]);
                tripCollection.Add(tripInfo);
            }
            reader.Close();
            return tripCollection;
        }

        public void PostByTripID(string tripID)
        {
            try
            {
                DataAccess.StartTransaction();
                DataAccess.PostByTripID(tripID);
                DataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public TripInfo SelectBusTripID(string routeID, DateTime date, string timeID)
        {
            TripInfo tripInfo = new TripInfo();
            IDataReader reader = DataAccess.SelectBusTripID(routeID, date, timeID);

            if (reader.Read())
            {
                tripInfo.TripID = Convert.ToString(reader["TripID"]);
                tripInfo.BusID = Convert.ToString(reader["BusID"]);
                tripInfo.BusNo = Convert.ToString(reader["BusNo"]);
                tripInfo.Price = Convert.ToInt32(reader["Price"]);
            }
            reader.Close();
            return tripInfo;
        }

        public TripCollection SelectListRecord()
        {
            TripCollection collection = new TripCollection();
            IDataReader Reader = DataAccess.SelectListRecord();

            while (Reader.Read())
            {
                TripInfo tripInfo = new TripInfo();
                tripInfo.TripID = Convert.ToString(Reader["TripID"]);
                tripInfo.TripCode = Convert.ToString(Reader["TripCode"]);
                tripInfo.TripDate = Convert.ToDateTime(Reader["Date"]);
                tripInfo.Time = Convert.ToString(Reader["Time"]);
                tripInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                tripInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                tripInfo.Driver1Name = Convert.ToString(Reader["DriverName"]);
                tripInfo.Driver2Name = Convert.ToString(Reader["DriverName"]);
                tripInfo.Price = Convert.ToDecimal(Reader["Price"]);
                collection.Add(tripInfo);
            }
            Reader.Close();
            return collection;
        }

        #region Reports
        public DataTable SelectListByTripCode(string fromTripCode, string toTripCode)
        {
            return DataAccess.SelectListByTripCode(fromTripCode, toTripCode);
        }

        public DataTable SelectListByRouteName(string routeName)
        {
            return DataAccess.SelectListByRouteName(routeName);
        }

        public DataTable SelectListByBusNo(string busNo)
        {
            return DataAccess.SelectListByBusNo(busNo);
        }

        public DataTable SelectListByDriverName(string driverid)
        {
            return DataAccess.SelectListByDriverID(driverid);
        }

        public DataTable SelectListByTripDate(string fromTripDate, string toTripDate)
        {
            return DataAccess.SelectListByTripDate(fromTripDate, toTripDate);
        }
        #endregion
    }
}