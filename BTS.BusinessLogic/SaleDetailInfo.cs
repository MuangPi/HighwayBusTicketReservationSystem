using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Data;
using BTS.DataAccess;
namespace BTS.BusinessLogic
{
   public class SaleDetailInfo
    {
        private string saleDetailID;
        public string SaleDetailID
        {
            get { return saleDetailID; }
            set { saleDetailID = value; }
        }

        private string saleID;
        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
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

    public class SaleDetailCollection : Collection<SaleDetailInfo> { }

    public class SaleDetailController
    {
        SaleDetailDataController DataAccess;

        public SaleDetailController()
        {
            DataAccess = new SaleDetailDataController();
        }

        public SaleDetailInfo SelectSaleDetail(string tripID, string saleID)
        {
            IDataReader Reader = DataAccess.SelectSaleDetail(tripID, saleID);
            SaleDetailInfo saleDetailInfo = new SaleDetailInfo();

            while (Reader.Read())
            {
                saleDetailInfo.SaleDetailID = Convert.ToString(Reader["SaleDetailID"]);
                saleDetailInfo.SeatNo = Convert.ToString(Reader["SeatNo"]);
            }
            Reader.Close();
            return saleDetailInfo;
        }
    }
}