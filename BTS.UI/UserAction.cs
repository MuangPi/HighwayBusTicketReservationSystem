using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BTS.UI
{
    public class UserAction
    {
        public void Log(string log)
        {
            string path = @"Log.txt";
            StreamWriter sw = new StreamWriter(path,true);

            string action = log + "("+System.DateTime.Now+")";

            sw.WriteLine(action);
            sw.Close();
        }

        public static String ReadFileString(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }

        }

        
        public String GetAction()
        {
            string getAction = ReadFileString(@"Log.txt");
            return getAction;
        }

        public void ClearLog()
        {
            string path = @"Log.txt";
            StreamWriter sw = new StreamWriter(path);
            LogIn logIN = new LogIn();
            string action = "History was clear"+ "By:"+ Globalizer.userName + "(" + System.DateTime.Now + ")";

            sw.WriteLine(action);
            sw.Close();
        }
    }
}
