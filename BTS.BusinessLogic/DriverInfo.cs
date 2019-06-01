using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class DriverInfo
    {
        private string driverID;
        public string DriverID
        {
            get { return driverID; }
            set { driverID = value; }
        }

       private string driverCode;
       public string DriverCode
       {
           get { return driverCode; }
           set { driverCode = value; }
       }

        private string driverName;
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

      
        private string driverLicence;
        public string DriverLicence
        {
            get { return driverLicence; }
            set { driverLicence = value; }
        }

        private string nrcNo;
        public string NRCNo
        {
            get { return nrcNo; }
            set { nrcNo = value; }
        }

        private string phoneNo;
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }

    public class DriverCollections : Collection<DriverInfo> { }

    public class DriverController
    {
        DriverDataController DataAccess;

        public DriverController()
        {
            DataAccess = new DriverDataController();
        }

        public void Insert(DriverInfo driverInfo)
        {
            DataAccess.Insert(driverInfo.DriverID,driverInfo.DriverCode, driverInfo.DriverName,driverInfo.DriverLicence, driverInfo.NRCNo,  driverInfo.PhoneNo, driverInfo.Address);
        }

        public void UpdateByDriverID(DriverInfo driverInfo)
        {
            DataAccess.UpdateByDriverID(driverInfo.DriverID, driverInfo.DriverCode, driverInfo.DriverName, driverInfo.DriverLicence, driverInfo.NRCNo, driverInfo.PhoneNo, driverInfo.Address);
        }

        public void DeleteByDriverID(string driverID)
        {
            DataAccess.DeleteByDriverID(driverID);
        }

        public DriverCollections SelectList()
        {
            DriverCollections collection = new DriverCollections();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                DriverInfo driverinfo = new DriverInfo();

                driverinfo.DriverID = Convert.ToString(Reader["DriverID"]);
                driverinfo.DriverCode = Convert.ToString(Reader["DriverCode"]);
                driverinfo.DriverName = Convert.ToString(Reader["DriverName"]);
                driverinfo.DriverLicence = Convert.ToString(Reader["DriverLicence"]);
                driverinfo.NRCNo = Convert.ToString(Reader["NRCNo"]);
                driverinfo.PhoneNo = Convert.ToString(Reader["PhoneNo"]);
                driverinfo.Address = Convert.ToString(Reader["Address"]);
                collection.Add(driverinfo);
            }
            Reader.Close();
            return collection;
        }
    }
}
