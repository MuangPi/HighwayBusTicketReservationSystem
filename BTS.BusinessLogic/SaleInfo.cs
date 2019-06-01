using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class SaleInfo
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

    public class SaleCollection : Collection<SaleInfo> { }

    public class SaleController
    {
        public string seatNo;
        DataControlBase DataControlBaseDataAccess;
        SaleDataController SaleDataAccess;
        SaleDetailDataController SaleDetailDataAccess;
        CustomerDataController CustomerDataAccess;
        TripDetailDataController TripDetailDataAccess;

        public SaleController()
        {
            DataControlBaseDataAccess = new DataControlBase();
            SaleDataAccess = new SaleDataController();
            SaleDetailDataAccess = new SaleDetailDataController();
            CustomerDataAccess = new CustomerDataController();
            TripDetailDataAccess = new TripDetailDataController();
        }

        public SaleInfo AutogenerateCode(string code)
        {
            SaleInfo saleInfo = new SaleInfo();
            saleInfo.AutoCode = SaleDataAccess.AutogenerateCode(code);

            return saleInfo;
        }

        public void AutogenerateReduce(string code)
        {
            SaleDataAccess.AutogenerateReduce(code);
        }

        public void Insert(SaleInfo saleInfo, CustomerInfo customerInfo, SaleDetailInfo saleDetailInfo)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                string customerID = CustomerDataAccess.CustomerInsert(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);

                string saleID = SaleDataAccess.SaleInsert(saleInfo.SaleID, saleInfo.SaleNo, saleInfo.SaleDate, saleInfo.Quantity, customerID);

                SaleDetailDataAccess.SaleDetailInsert(saleDetailInfo.SaleDetailID, saleID, saleDetailInfo.TripID, saleDetailInfo.SeatNo);

                if (saleDetailInfo.SeatNo != string.Empty)
                {
                    string seat = saleDetailInfo.SeatNo;
                    string[] array = seat.Split(',');
                    seatNo = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        seatNo = array[i];
                        TripDetailDataAccess.UpdateStatusByTripID(saleDetailInfo.TripID, seatNo, "S");
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

        public void Update(SaleInfo saleInfo, CustomerInfo customerInfo, SaleDetailInfo saleDetailInfo)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();

                CustomerDataAccess.CustomerUpdate(customerInfo.CustomerID, customerInfo.CustomerName, customerInfo.Gender, customerInfo.NRCNo, customerInfo.PhoneNo);

                SaleDataAccess.SaleUpdate(saleInfo.SaleID, saleInfo.SaleNo, saleInfo.SaleDate, saleInfo.Quantity, customerInfo.CustomerID);

                SaleDetailDataAccess.SaleDetailUpdate(saleDetailInfo.SaleDetailID, saleInfo.SaleID, saleDetailInfo.TripID, saleDetailInfo.SeatNo);

                if (saleDetailInfo.SeatNo != null)
                {
                    string seat = saleDetailInfo.SeatNo;
                    string[] array = seat.Split(',');
                    seatNo = "";
                    for (int i = 0; i < array.Length; i++)
                    {
                        seatNo = array[i];
                        TripDetailDataAccess.UpdateStatusByTripID(saleDetailInfo.TripID, seatNo, "S");
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

        public void Delete(string tripID, string saleID)
        {
            try
            {
                DataControlBaseDataAccess.StartTransaction();


                SaleDetailController controller = new SaleDetailController();
                SaleDetailInfo saleDetailInfo = controller.SelectSaleDetail(tripID, saleID);

                SaleDetailDataAccess.SaleDetailDeleteSaleID(tripID, saleID);
                SaleDataAccess.SaleDelete(saleID);

                string seat = saleDetailInfo.SeatNo;
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

        public void TripDetailUpdate(SaleDetailInfo saleDetailInfo)//for edit
        {
            if (saleDetailInfo.SeatNo != null)
            {
                string seat = saleDetailInfo.SeatNo;
                string[] array = seat.Split(',');
                seatNo = "";
                for (int i = 0; i < array.Length; i++)
                {
                    seatNo = array[i];
                    TripDetailDataAccess.UpdateStatusByTripID(saleDetailInfo.TripID, seatNo, "A");
                }
            }
        }

        public SaleCollection SelectList()
        {
            SaleCollection collection = new SaleCollection();
            IDataReader Reader = SaleDataAccess.SelectList();

            while (Reader.Read())
            {
                SaleInfo saleInfo = new SaleInfo();
                saleInfo.SaleID = Convert.ToString(Reader["SaleID"]);
                saleInfo.SaleNo = Convert.ToString(Reader["SaleNo"]);
                saleInfo.SaleDate = Convert.ToDateTime(Reader["SaleDate"]);
                saleInfo.Quantity = Convert.ToInt32(Reader["Quantity"]);
                saleInfo.CustomerID = Convert.ToString(Reader["CustomerID"]);
                collection.Add(saleInfo);
            }
            Reader.Close();
            return collection;
        }

        #region Reports
        public DataTable SelectMonthlySummary(string month, string year)
        {
            return SaleDataAccess.SelectMonthlySummary(month, year);
        }

        public DataTable SelectMonthlyDetail(string month, string year)
        {
            return SaleDataAccess.SelectMonthlyDetail(month, year);
        }

        public DataTable SelectYearlySummary(string year)
        {
            return SaleDataAccess.SelectYearlySummary(year);
        }

        public DataTable SelectYearlyDetail(string year)
        {
            return SaleDataAccess.SelectYearlyDetail(year);
        }

        public DataTable SelectSummaryBySaleNo(string fromSaleNo, string toSaleNo)
        {
            return SaleDataAccess.SelectSummaryBySaleNo(fromSaleNo, toSaleNo);
        }

        public DataTable SelectDetailBySaleNo(string fromSaleNo, string toSaleNo)
        {
            return SaleDataAccess.SelectDetailBySaleNo(fromSaleNo, toSaleNo);
        }

        public DataTable SelectSummaryByTripOne(string routeName, DateTime date, string time)
        {
            return SaleDataAccess.SelectSummaryByTripOne(routeName, date, time);
        }

        public DataTable SelectDetailByTripOne(string routeName, DateTime date, string time)
        {
            return SaleDataAccess.SelectDetailByTripOne(routeName, date, time);
        }

        public DataTable SelectSummaryBySaleDate(string fromSaleDate,string toSaleDate)
        {
            return SaleDataAccess.SelectSummaryBySaleDate(fromSaleDate, toSaleDate);
        }

        public DataTable SelectDetailBySaleDate(string fromSaleDate, string toSaleDate)
        {
            return SaleDataAccess.SelectDetailBySaleDate(fromSaleDate, toSaleDate);
        }


        public DataTable SelectSummaryByTripCode(string fromTripCode, string toTripCode)
        {
            return SaleDataAccess.SelectSummaryByTripCode(fromTripCode, toTripCode);
        }

        public DataTable SelectDetailByTripCode(string fromTripCode, string toTripCode)
        {
            return SaleDataAccess.SelectDetailByTripCode(fromTripCode, toTripCode);
        }

        public void PostBySaleNo(string fromSaleNo, string toSaleNo)
        {
            try
            {
                SaleDataAccess.StartTransaction();
                SaleDataAccess.PostBySaleNo(fromSaleNo, toSaleNo);
                SaleDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                SaleDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public void PostBySaleDate(DateTime fromSaleDate, DateTime toSaleDate)
        {
            try
            {
                SaleDataAccess.StartTransaction();
                SaleDataAccess.PostBySaleDate(fromSaleDate, toSaleDate);
                SaleDataAccess.CommitTransaction();
            }
            catch (Exception ex)
            {
                SaleDataAccess.RollBackTransaction();
                throw ex;
            }
        }

        public DataTable DailyReport(string date)
        {
            return SaleDataAccess.DailyReport(date);
        }
        #endregion
    }
}
