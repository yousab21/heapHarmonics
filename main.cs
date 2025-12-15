
using System;
using System.Threading;
using messages;
using users;
using utils;
using data;
using mainApp;
using System.Security.Cryptography.X509Certificates;

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
    bool found = false;
    foreach (RegularUser ru in Data.allRegularUsers)
    {
           if (ru.GetUserId() == ID)
           {
              currentRegularUser = ru;
              Mode = "Regular";
              found = true;
              break;
           }
    }
           if (!found)
           {
            Console.WriteLine("Invalid ID");
           }
          break;

    case 'G':
        foreach (GuestUser gu in Data.allGuestUsers)
         {
           if (ru.GetUserId() == ID)
           {
              currentRegularUser = ru;
              Mode = "Regular";
              found = true;
              break;
           }
         }
           if (!found)
           {
            Console.WriteLine("Invalid ID");
           }
          break;
    case 'A':
        foreach (AdminUser au in Data.allAdminUsers)
         {
           if (ru.GetUserId() == ID)
           {
              currentRegularUser = ru;
              Mode = "Regular";
              found = true;
              break;
           }
         }
           if (!found)
           {
            Console.WriteLine("Invalid ID");
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
  SwitchUser("AU1");

        screens.WelcomeScreen();
        
        while(true){

        if (Mode==""){
        screens.LoginScreen();
        }

        switch (Mode)
        {
          case "Admin":
            screens.AdminMenu();
            break;
          case "Regular":
            screens.RegularMenu();
            break;
          case "Guest":
            screens.GuestMenu();
            break;
          default:
            break;
        }
    }
}
}
}
