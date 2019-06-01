using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class BookingDetailInfo
    {
        private string bookingDetailID;
        public string BookingDetailID
        {
            get { return bookingDetailID; }
            set { bookingDetailID = value; }
        }

        private string bookingID;
        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
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
    }

     public class BookingDetailCollection : Collection<BookingDetailInfo> { }

    public class BookingDetailController
    {
        BookingDetailDataController DataAccess;

        public BookingDetailController()
        {
            DataAccess = new BookingDetailDataController();
        }

        public BookingDetailCollection BookingDetailSeatNo(string tripID)
        {
            BookingDetailCollection collection = new BookingDetailCollection();
            IDataReader Reader = DataAccess.BookingDetailSeatNo(tripID);

            while (Reader.Read())
            {
                BookingDetailInfo info = new BookingDetailInfo();
                info.BookingID = Convert.ToString(Reader["BookingID"]);
                info.SeatNo = Convert.ToString(Reader["SeatNo"]);

                collection.Add(info);
            }
            Reader.Close();
            return collection;
        }

        public string BookingDetailBookingID(string tripID)
        {
            return DataAccess.BookingDetailBookingID(tripID);
        }

        public BookingDetailInfo SelectBookingDetail(string tripID, string bookingID)
        {
            IDataReader Reader = DataAccess.SelectBookingDetail(tripID, bookingID);
            BookingDetailInfo bookingDetailInfo = new BookingDetailInfo();

            while (Reader.Read())
            {
               
                bookingDetailInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
            }
            Reader.Close();
            return bookingDetailInfo;
        }
    }

}
