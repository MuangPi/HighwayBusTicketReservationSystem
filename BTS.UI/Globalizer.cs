using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;//for DialogResult
using System.Configuration;//for ConfigurationManager

namespace BTS.UI
{
    public enum MessageType
    {
        Information,
        Warning,
        Critical,
        Question,
    }

   public class Globalizer
    {
       public static bool enable;
       public static string userName = string.Empty;//for log 
       public static DialogResult ShowMessage(MessageType messageType, string message)
       {
           
           DialogResult result = DialogResult.None;
           switch (messageType)
           {
               case MessageType.Information:
                   MessageBox.Show(message,ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                   break;

               case MessageType.Warning:
                   MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(),
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   break;

               case MessageType.Critical:
                   MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                   break;

               case MessageType.Question:
                   result = MessageBox.Show(message, ConfigurationManager.AppSettings["MessageBoxTitle"].ToString(),
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   break;

           }
           return result;
       }
    }
}
