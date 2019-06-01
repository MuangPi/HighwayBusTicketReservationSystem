using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
  public  class TimeScheduleInfo
    {
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

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

    public class TimeCollections : Collection<TimeScheduleInfo> { }

    public class TimeScheduleController
    {
        TimeScheduleDataController DataAccess;

        public TimeScheduleController()
        {
            DataAccess = new TimeScheduleDataController();
        }

        public void Insert(TimeScheduleInfo timeInfo)
        {
            DataAccess.Insert(timeInfo.TimeID, timeInfo.Time, timeInfo.Description);
        }

        public void UpdateByTimeID(TimeScheduleInfo timeInfo)
        {
            DataAccess.UpdateByTimeID(timeInfo.TimeID, timeInfo.Time, timeInfo.Description);
        }

        public void DeleteByTimeID(string timeID)
        {
            DataAccess.DeleteByTimeID(timeID);
        }

        public TimeCollections SelectList()
        {
            TimeCollections collection = new TimeCollections();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                TimeScheduleInfo timeinfo = new TimeScheduleInfo();

                timeinfo.TimeID = Convert.ToString(Reader["TimeID"]);
                timeinfo.Time = Convert.ToString(Reader["Time"]);
                timeinfo.Description = Convert.ToString(Reader["Description"]);
                collection.Add(timeinfo);
            }
            Reader.Close();
            return collection;
        }
    }
}
