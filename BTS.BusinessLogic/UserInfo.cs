using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using BTS.DataAccess;


namespace BTS.BusinessLogic
{
    public class UserInfo
    {
        private string userID;
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string userLevelID;
        public string UserLevelID
        {
            get { return userLevelID; }
            set { userLevelID = value; }
        }

        private string userLevel;
        public string UserLevel
        {
            get { return userLevel; }
            set { userLevel = value; }
        }
    }

    public class UserCollection : Collection<UserInfo> { }

    public class UserController
    {
        UserDataController DataAccess = new UserDataController();

        public UserController()
        {
            DataAccess = new UserDataController();
        }

        public void Insert(UserInfo userInfo)
        {
            DataAccess.Insert(userInfo.UserID, userInfo.Name, userInfo.UserName, userInfo.Password, userInfo.UserLevelID);
        }

        public void UpdateByUserID(UserInfo userInfo)
        {
            DataAccess.Update(userInfo.UserID, userInfo.Name, userInfo.UserName, userInfo.Password, userInfo.UserLevelID);
        }

        public void DeleteByUserID(string userID)
        {
            DataAccess.DeleteByUserID(userID);
        }

        public UserCollection SelectList()
        {
            UserCollection collection = new UserCollection();
            IDataReader Reader = DataAccess.SelectList();

            while (Reader.Read())
            {
                UserInfo userinfo = new UserInfo();
                userinfo.UserID = Convert.ToString(Reader["UserID"]);
                userinfo.Name = Convert.ToString(Reader["Name"]);
                userinfo.UserName = Convert.ToString(Reader["UserName"]);
                userinfo.Password = Convert.ToString(Reader["Password"]);
                userinfo.UserLevelID = Convert.ToString(Reader["UserLevelID"]);
                userinfo.UserLevel = Convert.ToString(Reader["UserLevel"]);
                collection.Add(userinfo);
            }
            Reader.Close();
            return collection;
        }

        public UserInfo SelectByUserID(string userID)
        {
            IDataReader Reader = DataAccess.SelectByUserID(userID);
            UserInfo userInfo = new UserInfo();

            if (Reader.Read())
            {
                userInfo.UserID = Convert.ToString(Reader["UserID"]);
                userInfo.Name = Convert.ToString(Reader["Name"]);
                userInfo.UserName = Convert.ToString(Reader["UserName"]);
                userInfo.Password = Convert.ToString(Reader["Password"]);
                userInfo.UserLevelID = Convert.ToString(Reader["UserLevelID"]);
            }
            Reader.Close();
            return userInfo;
        }

        public string CheckUserNameAndPassword(string userName, string password)
        {
            return DataAccess.CheckUserNameAndPassword(userName, password);
        }
    }
}
