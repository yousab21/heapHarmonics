
using System;
using System.Threading;
using messages;
using users;
using utils;
using data;
class main
{
  public static void Main(string[] args)
  {
    ConsoleUtils.Refresh();
    Data.InitializeData();


    Data.SuperAdmin.Add_User();
    Data.SuperAdmin.Add_User();

    Data.SuperAdmin.ViewAllUsers();

    Data.allRegularUsers[0].SendTextMessage();
    Data.allRegularUsers[0].SendVoiceMessage();
    Data.allRegularUsers[0].SendImageMessage();

    Data.SuperAdmin.ViewAllMessages();

  }
}