using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class RouteInfo
    {
        private string routeID;
       public string RouteID
       {
           get { return routeID; }
           set { routeID = value; }
       }

       private string routeCode;
       public string RouteCode
       {
           get { return routeCode; }
           set { routeCode = value; }
       }

       private string routeName;
       public string RouteName
       {
           get { return routeName; }
           set { routeName = value; }
       }

       private string fromLocationID;
       public string FromLocationID
       {
           get { return fromLocationID; }
           set { fromLocationID = value; }
       }

       private string fromLocationName;
       public string FromLocationName
       {
           get { return fromLocationName; }
           set { fromLocationName = value; }
       }

       private string toLocationID;
       public string ToLocationID
       {
           get { return toLocationID; }
           set { toLocationID = value; }
       }

       private string toLocationName;
       public string ToLocationName
       {
           get { return toLocationName; }
           set { toLocationName = value; }
       }
    }

    public class RouteCollections : Collection<RouteInfo> { }

    public class RouteController
    {
        RouteDataController DataAccess;

        public RouteController()
        {
            DataAccess = new RouteDataController();
        }

        public void Insert(RouteInfo routeInfo)
        {
            DataAccess.Insert(routeInfo.RouteID, routeInfo.RouteCode, routeInfo.RouteName, routeInfo.FromLocationID, routeInfo.ToLocationID);
        }

        public void UpdateByRouteID(RouteInfo routeInfo)
        {
            DataAccess.UpdateByRouteID(routeInfo.RouteID, routeInfo.RouteCode, routeInfo.RouteName, routeInfo.FromLocationID, routeInfo.ToLocationID);
        }

        public void DeleteByRouteID(string routeID)
        {
            DataAccess.DeleteByRouteID(routeID);
        }

        public RouteCollections SelectList()
        {
            RouteCollections collection = new RouteCollections();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                RouteInfo routeinfo = new RouteInfo();
                routeinfo.RouteID = Convert.ToString(Reader["RouteID"]);
                routeinfo.RouteCode = Convert.ToString(Reader["RouteCode"]);
                routeinfo.RouteName = Convert.ToString(Reader["RouteName"]);
                routeinfo.FromLocationID = Convert.ToString(Reader["FromLocationID"]);
                routeinfo.FromLocationName = Convert.ToString(Reader["LocationName"]);
                routeinfo.ToLocationID = Convert.ToString(Reader["ToLocationID"]);
                routeinfo.ToLocationName = Convert.ToString(Reader["LocationName"]);
                collection.Add(routeinfo);
            }
            Reader.Close();
            return collection;
        }

        public RouteInfo SelectByRouteID(string routeID)
        {
            IDataReader Reader = DataAccess.SelectByRouteID(routeID);
            RouteInfo routeInfo = new RouteInfo();

            while (Reader.Read())
            {
                routeInfo.RouteID = Convert.ToString(Reader["RouteID"]);
                routeInfo.RouteCode = Convert.ToString(Reader["RouteCode"]);
                routeInfo.RouteName = Convert.ToString(Reader["RouteName"]);
                routeInfo.FromLocationID = Convert.ToString(Reader["FromLocationID"]);
                routeInfo.ToLocationID = Convert.ToString(Reader["ToLocationID"]);
            }
            Reader.Close();
            return routeInfo;
        }
    }
}