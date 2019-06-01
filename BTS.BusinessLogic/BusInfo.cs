using System;
using System.Collections.ObjectModel;
using System.Data;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
    public class BusInfo
    {
        private string busID;
        public string BusID
        {
            get { return busID; }
            set { busID = value; }
        }

        private string busCode;
        public string BusCode
        {
            get { return busCode; }
            set { busCode = value; }
        }

        private string busNo;
        public string BusNo
        {
            get { return busNo; }
            set { busNo = value; }
        }

        private string busTypeID;
        public string BusTypeID
        {
            get { return busTypeID; }
            set { busTypeID = value; }
        }

        private string busTypeDescription;
        public string BusTypeDescription
        {
            get { return busTypeDescription; }
            set { busTypeDescription = value; }
        }

        private int totalSeats;
        public int TotalSeats
        {
            get { return totalSeats; }
            set { totalSeats = value; }
        }
    }

    public class BusCollection : Collection<BusInfo> { }

    public class BusController
    {
        BusDataController DataAccess;

        public BusController()
        {
            DataAccess = new BusDataController();
        }

        public void Insert(BusInfo busInfo)
        {
            DataAccess.Insert(busInfo.BusID, busInfo.BusCode, busInfo.BusNo, busInfo.BusTypeID);
        }

        public void UpdateByBusID(BusInfo busInfo)
        {
            DataAccess.UpdateByBusID(busInfo.BusID, busInfo.BusCode, busInfo.BusNo, busInfo.BusTypeID);
        }

        public void DeleteByBusID(string busID)
        {
            DataAccess.DeleteByBusID(busID);
        }

        public BusCollection SelectList()
        {
            BusCollection collection = new BusCollection();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                BusInfo businfo = new BusInfo();

                businfo.BusID = Convert.ToString(Reader["BusID"]);
                businfo.BusCode = Convert.ToString(Reader["BusCode"]);
                businfo.BusNo = Convert.ToString(Reader["BusNo"]);
                businfo.BusTypeID = Convert.ToString(Reader["BusTypeID"]);
                businfo.BusTypeDescription = Convert.ToString(Reader["Description"]);
                businfo.TotalSeats = Convert.ToInt32(Reader["TotalSeats"]);
                collection.Add(businfo);
            }
            Reader.Close();
            return collection;
        }

        public BusInfo SelectByBusID(string busID)
        {
            IDataReader Reader = DataAccess.SelectByBusID(busID);
            BusInfo busInfo = new BusInfo();

            if (Reader.Read())
            {
                busInfo.BusID = Convert.ToString(Reader["BusID"]);
                busInfo.BusCode = Convert.ToString(Reader["BusCode"]);
                busInfo.BusNo = Convert.ToString(Reader["BusNo"]);
                busInfo.BusTypeID = Convert.ToString(Reader["BusTypeID"]);
                busInfo.TotalSeats = Convert.ToInt32(Reader["TotalSeats"]);
            }
            Reader.Close();
            return busInfo;
        }

        public DataTable SelectBus()
        {
            return DataAccess.SelectBus();
        }
    }
}
