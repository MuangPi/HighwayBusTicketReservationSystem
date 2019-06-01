using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Text;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
    public class TripDetailInfo
    {
        private string _tripDetailID;
        public string TripDetailID
        {
            get { return _tripDetailID; }
            set { _tripDetailID = value; }
        }

        private string _tripID;
        public string TripID
        {
            get { return _tripID; }
            set { _tripID = value; }
        }

        private string _seatNo;
        public string SeatNo
        {
            get { return _seatNo; }
            set { _seatNo = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }

    public class TripDetailCollection : Collection<TripDetailInfo> { }

    public class TripDetailController
    {
        TripDetailDataController DataAccess;

        public TripDetailController()
        {
            DataAccess = new TripDetailDataController();
        }

        public TripDetailCollection SelectDetailByTripID(string tripID)
        {
            TripInfo tripInfo = new TripInfo();
            string TripID = Convert.ToString(tripInfo.TripID);
            IDataReader Reader = DataAccess.SelectDetailByTripID(tripID);
            TripDetailCollection collection = new TripDetailCollection();

            while (Reader.Read())
            {
                TripDetailInfo tripDeatilInfo = new TripDetailInfo();
                tripDeatilInfo.TripID = TripID;
                tripDeatilInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
                tripDeatilInfo.Status = Convert.ToString(Reader["Status"]);
                collection.Add(tripDeatilInfo);
            }
            Reader.Close();
            return collection;
        }

        public void UpdateStatusByTripID(string tripID, string seatNo, string status)
        {
            DataAccess.UpdateStatusByTripID(tripID, seatNo, status);
        }   
    }
}
