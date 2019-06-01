using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
    public class BookingInfo
    {
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

        private string autocode;
        public string AutoCode
        {
            get { return autocode; }
            set { autocode = value; }
        }
    }

    public class BookingCollection : Collection<BookingInfo> { }

    public class BookingController
    {
        public string seatNo;
        BookingDataController BookingDataAccess;
        CustomerDataController CustomerDataAccess;
        BookingDetailDataController BookingDetailDataAccess;
        TripDetailDataController TripDetailDataAccess;
        TripDataController TripDataAccess;
        SaleDataController SaleDataAccess;
        DataControlBase DataControlBaseDataAccess;

        public BookingController()
        {
            BookingDataAccess = new BookingDataController();
            CustomerDataAccess = new CustomerDataController();
            BookingDetailDataAccess = new BookingDetailDataController();
            TripDetailDataAccess = new TripDetailDataController();
            TripDataAccess = new TripDataController();
            SaleDataAccess = new SaleDataController();
            DataControlBaseDataAccess = new DataControlBase();
        }

        public void Insert(BookingInfo bookingInfo, CustomerInfo customerInfo, BookingDetailInfo bookingDetailInfo)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                string CustomerID = CustomerDataAccess.CustomerInsert(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);

                string BookingID = BookingDataAccess.BookingInsert(bookingInfo.BookingID, bookingInfo.BookingNo, bookingInfo.BookingDate, bookingInfo.Quantity, CustomerID);

                BookingDetailDataAccess.BookingDetailInsert(bookingDetailInfo.BookingDetailID, BookingID, bookingDetailInfo.TripID, bookingDetailInfo.SeatNo);

                if (bookingDetailInfo.SeatNo != null)
                {
                    string seat = bookingDetailInfo.SeatNo;
                    string[] array = seat.Split(',');
                    seatNo = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        seatNo = array[i];
                        TripDetailDataAccess.UpdateStatusByTripID(bookingDetailInfo.TripID, seatNo, "B");
                    }
                }

                DataControlBaseDataAccess.CommitTransaction();

            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void Update(BookingInfo bookingInfo, CustomerInfo customerInfo, BookingDetailInfo bookingDetailInfo)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                CustomerDataAccess.CustomerUpdate(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);

                BookingDataAccess.BookingUpdate(bookingInfo.BookingID, bookingInfo.BookingNo, bookingInfo.BookingDate, bookingInfo.Quantity, customerInfo.CustomerID);

                BookingDetailDataAccess.BookingDetailUpdate(bookingDetailInfo.BookingDetailID, bookingInfo.BookingID, bookingDetailInfo.TripID, bookingDetailInfo.SeatNo);

                if (bookingDetailInfo.SeatNo != null)
                {
                    string seat = bookingDetailInfo.SeatNo;
                    string[] array = seat.Split(',');
                    seatNo = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        seatNo = array[i];
                        TripDetailDataAccess.UpdateStatusByTripID(bookingDetailInfo.TripID, seatNo, "B");
                    }
                }
                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void Delete(string tripID, string bookingID)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                BookingDetailController controller = new BookingDetailController();
                BookingDetailInfo bookingDetailInfo = controller.SelectBookingDetail(tripID, bookingID);


                BookingDetailDataAccess.BookingDetailDeleteBookingID(tripID, bookingID);
                BookingDataAccess.BookingDelete(bookingID);


                string seat = bookingDetailInfo.SeatNo;
                string[] array = seat.Split(',');
                seatNo = "";
                for (int i = 0; i < array.Length; i++)
                {
                    seatNo = array[i];
                    TripDetailDataAccess.UpdateStatusByTripID(tripID, seatNo, "A");

                }
                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }


        public BookingInfo AutogenerateCode(string code)
        {
            BookingInfo bookingInfo = new BookingInfo();
            bookingInfo.AutoCode = BookingDataAccess.AutogenerateCode(code);

            return bookingInfo;
        }

        public void AutogenerateReduce(string code)
        {
            BookingDataAccess.AutogenerateReduce(code);
        }

        public void CancelBooking(string routeName, DateTime date, string time)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                string tripID = TripDataAccess.SelectInfoByTripID(routeName, date, time);

                BookingDetailController controller = new BookingDetailController();
                BookingDetailCollection bookingDetailCollection = controller.BookingDetailSeatNo(tripID);


                BookingDetailDataAccess.BookingDetailBookingID(tripID);

                foreach (BookingDetailInfo info in bookingDetailCollection)
                {
                    BookingDataAccess.BookingDelete(info.BookingID);
                    string seat = info.SeatNo;
                    string[] array = seat.Split(',');
                    seatNo = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        seatNo = array[i];
                        TripDetailDataAccess.UpdateStatusByTripID(tripID, seatNo, "A");
                    }
                }

                DataControlBaseDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void Confirm(string tripID, string bookingID)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                BookingDetailController controller = new BookingDetailController();
                BookingDetailInfo info = controller.SelectBookingDetail(tripID, bookingID);

                string seat = info.SeatNo;
                string[] array = seat.Split(',');
                seatNo = "";
                for (int i = 0; i < array.Length; i++)
                {
                    seatNo = array[i];
                    TripDetailDataAccess.UpdateStatusByTripID(tripID, seatNo, "S");
                }

                string autoCode = SaleDataAccess.AutogenerateCode("Sale");

                BookingDataAccess.Confirm(bookingID, autoCode);
            }
            catch (Exception ex)
            {
                DataControlBaseDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void TripDetailUpdate(BookingDetailInfo bookingDetailInfo)
        {
            if (bookingDetailInfo.SeatNo != null)
            {
                string seat = bookingDetailInfo.SeatNo;
                string[] array = seat.Split(',');
                seatNo = "";
                for (int i = 0; i < array.Length; i++)
                {
                    seatNo = array[i];
                    TripDetailDataAccess.UpdateStatusByTripID(bookingDetailInfo.TripID, seatNo, "A");
                }
            }
        }
    }
}
