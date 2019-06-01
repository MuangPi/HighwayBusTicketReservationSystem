using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;

namespace BTS.BusinessLogic
{
   public class UserLevelInfo
    {
        private string userLevelID;
        public string UserLevelID
        {
            get { return userLevelID; }
            set { userLevelID = value; }
        }

        private string userLevelCode;
        public string UserLevelCode
        {
            get { return userLevelCode; }
            set { userLevelCode = value; }
        }

        private string userLevel;
        public string UserLevel
        {
            get { return userLevel; }
            set { userLevel = value; }
        }
    }

    public class UserLevelCollections : Collection<UserLevelInfo> { }

    public class UserLevelController
    {
        UserLevelDataController DataAccess;

        public UserLevelController()
        {
            DataAccess = new UserLevelDataController();
        }

        public void Insert(UserLevelInfo userLevelInfo)
        {
            DataAccess.Insert(userLevelInfo.UserLevelID, userLevelInfo.UserLevelCode, userLevelInfo.UserLevel);
        }

        public void UpdateByUserLevelID(UserLevelInfo userLevelInfo)
        {
            DataAccess.UpdateByUserLevelID(userLevelInfo.UserLevelID, userLevelInfo.UserLevelCode, userLevelInfo.UserLevel);
        }

        public void DeleteByUserLevelID(string userLevelID)
        {
            DataAccess.DeleteByUserLevelID(userLevelID);
        }

        public UserLevelCollections SelectList()
        {
            UserLevelCollections collection = new UserLevelCollections();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                UserLevelInfo userlevelinfo = new UserLevelInfo();

                userlevelinfo.UserLevelID = Convert.ToString(Reader["UserLevelID"]);
                userlevelinfo.UserLevelCode = Convert.ToString(Reader["UserLevelCode"]);
                userlevelinfo.UserLevel = Convert.ToString(Reader["UserLevel"]);
                collection.Add(userlevelinfo);
            }
            Reader.Close();
            return collection;
        }
    }
}