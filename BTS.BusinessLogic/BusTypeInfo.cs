using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//for IDataReader
using System.Collections.ObjectModel;//for collection
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class BusTypeInfo
    {
        private string busTypeID;
        public string BusTypeID
        {
            get { return busTypeID; }
            set { busTypeID = value; }
        }

        private string busTypeCode;
        public string BusTypeCode
        {
            get { return busTypeCode; }
            set { busTypeCode = value; }
        }

       private string description;
       public string Description
       {
           get { return description; }
           set { description = value; }
       }

        private int totalSeats;
        public int TotalSeats
        {
            get { return totalSeats; }
            set { totalSeats = value; }
        }
    }

    public class BusTypeCollections : Collection<BusTypeInfo> { }

    public class BusTypeController
    {
        BusTypeDataController DataAccess;

        public BusTypeController()
        {
            DataAccess = new BusTypeDataController();
        }

        public void Insert(BusTypeInfo busTypeInfo)
        {
            DataAccess.Insert(busTypeInfo.BusTypeID, busTypeInfo.BusTypeCode, busTypeInfo.Description, busTypeInfo.TotalSeats);
        }
        
        public void UpdateByBusTypeID(BusTypeInfo busTypeInfo)
        {
            DataAccess.UpdateByBusTypeID(busTypeInfo.BusTypeID, busTypeInfo.BusTypeCode,busTypeInfo.Description, busTypeInfo.TotalSeats);
             
        }

        public void DeleteByBusTypeID(string busTypeID)
        {
                DataAccess.DeleteByBusTypeID(busTypeID);
        }

        public BusTypeCollections SelectList()
        {
            BusTypeCollections collection = new BusTypeCollections();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                BusTypeInfo busTypeInfo = new BusTypeInfo();
                busTypeInfo.BusTypeID = Convert.ToString(Reader["BusTypeID"]);
                busTypeInfo.BusTypeCode = Convert.ToString(Reader["BusTypeCode"]);
                busTypeInfo.Description = Convert.ToString(Reader["Description"]);
                busTypeInfo.TotalSeats = Convert.ToInt32(Reader["TotalSeats"]);
                collection.Add(busTypeInfo);
            }
            Reader.Close();
            return collection;
        }

        public BusTypeInfo SelectByBusTypeID(string busTypeID)
        {
            IDataReader Reader = DataAccess.SelectByBusTypeID(busTypeID);
            BusTypeInfo busTypeInfo = new BusTypeInfo();

            if (Reader.Read())
            {
                busTypeInfo.BusTypeID = Convert.ToString(Reader["BusTypeID"]);
                busTypeInfo.BusTypeCode = Convert.ToString(Reader["BusTypeCode"]);
                busTypeInfo.Description = Convert.ToString(Reader["Description"]);
                busTypeInfo.TotalSeats = Convert.ToInt32(Reader["TotalSeats"]);
            }
            Reader.Close();
            return busTypeInfo;
        }
    }
}
