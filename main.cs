
using System;
using System.Threading;
using messages;
using users;
using utils;
using data;
using mainApp;

namespace mainApp
{


class main
{

  public static string Mode="";
  public static RegularUser currentRegularUser ;
  public static GuestUser currentGuestUser ;
  public static AdminUser currentAdminUser ;
  public static void SwitchUser(string ID)
  {
{

 switch (ID[0])
 {
    case 'R':
        foreach (RegularUser ru in Data.allRegularUsers)
        {
            if (ru.GetUserId() == ID)
            {
                currentRegularUser = ru;
                Mode="Regular";
                break;
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
        break;
    case 'G':
        foreach (GuestUser gu in Data.allGuestUsers)
        {
            if (gu.GetUserId() == ID)
            {
                currentGuestUser = gu;
                Mode="Guest";
                break;
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
        break;
    case 'A':
        foreach (AdminUser au in Data.allAdminUsers)
        {
            if (au.GetUserId() == ID)
            {
                currentAdminUser = au;
                Mode="Admin";
                break;
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
        break;
    default:
        Console.WriteLine("Invalid ID");
        break;
 }
}
}
  public static void Main(string[] args)
  {
  ConsoleUtils.Refresh();
  Data.InitializeData();
  currentAdminUser=Data.SuperAdmin;

  currentAdminUser.Add_User();
  currentAdminUser.ViewAllUsers();

  Console.WriteLine("Enter your User ID to switch:");
  string userID=Console.ReadLine();
  SwitchUser(userID);

  switch (Mode)
      {
        case "Regular":
          Console.WriteLine($"Switched to Regular User: {currentRegularUser.GetName()}");
          break;
        case "Admin":
          Console.WriteLine($"Switched to Admin User: {currentAdminUser.GetName()}");
          break;
        case "Guest":
          Console.WriteLine($"Switched to Guest User: {currentGuestUser.GetName()}");
          break;    
      }
  }
  // ConsoleUtils.Refresh();
  //   Data.InitializeData();


  //   Data.SuperAdmin.Add_User();
  //   Data.SuperAdmin.Add_User();

  //   Data.SuperAdmin.ViewAllUsers();

  //   Data.allRegularUsers[0].SendTextMessage();
  //   Data.allRegularUsers[0].SendVoiceMessage();
  //   Data.allRegularUsers[0].SendImageMessage();

  //   Data.SuperAdmin.ViewAllMessages();
}
}