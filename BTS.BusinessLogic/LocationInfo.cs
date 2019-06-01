using System;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
    public class LocationInfo
    {
        private string _locationID;
        public string LocationID
        {
            get { return _locationID; }
            set { _locationID = value; }
        }

        private string _locationCode;
        public string LocationCode
        {
            get { return _locationCode; }
            set { _locationCode = value; }
        }

        private string _locationName;
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }
    }

    public class LocationCollection : Collection<LocationInfo> { }

    public class LocationController
    {
        LocationDataController dataAccess;

        public LocationController()
        {
            dataAccess = new LocationDataController();
        }

        public void Insert(LocationInfo locationInfo)
        {
            dataAccess.Insert(locationInfo.LocationID, locationInfo.LocationCode, locationInfo.LocationName);
        }

        public void UpdateByLocationID(LocationInfo locationInfo)
        {
            dataAccess.UpdateByLocationID(locationInfo.LocationID, locationInfo.LocationCode, locationInfo.LocationName);
        }

        public void DeleteByLocationID(LocationInfo locationInfo)
        {
            dataAccess.DeleteByLocationID(locationInfo.LocationID);
        }

        public LocationCollection SelectList()
        {
            LocationCollection collection = new LocationCollection();
            IDataReader reader = dataAccess.SelectList();

            while (reader.Read())
            {
                LocationInfo locationInfo = new LocationInfo();

                locationInfo.LocationID = Convert.ToString(reader["LocationID"]);
                locationInfo.LocationCode = Convert.ToString(reader["LocationCode"]);
                locationInfo.LocationName = Convert.ToString(reader["LocationName"]);
                collection.Add(locationInfo);
            }
            reader.Close();
            return collection;
        }
    }
}
