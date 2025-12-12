using System;
using users;
using utils;
using data;
using mainApp;
using messages;

namespace mainApp
{
  class screens
  {
    public static void WelcomeScreen()
    {
        Console.WriteLine("Welcome to SHELL-Chat !");
        Console.WriteLine("HeapHarmonics's CLI based chat application");
    }

    public static void LoginScreen()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Please enter your User ID to log in:");
      Console.ResetColor();
      string userID=Console.ReadLine();
      main.SwitchUser(userID);
    }

    public static void AdminMenu()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Welcome " + main.currentAdminUser.GetName() + " (Admin)");
      Console.ResetColor();
      Console.WriteLine("===================================");
      Console.WriteLine("1. Add User");
      Console.WriteLine("2. Block User");
      Console.WriteLine("3. change User Status");
      Console.WriteLine("4. View Online Users");
      Console.WriteLine("5. View All Users");
      Console.WriteLine("6. View All Messages");
      Console.WriteLine("7. Delete All Messages");
      Console.WriteLine("8. Send To Public Chat");
      Console.WriteLine("9. View Public Chat");
      Console.WriteLine("10. Log Out");
      Console.WriteLine("===================================");
      
      bool validChoice = false;
      
    while (!validChoice){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Enter your choice: ");
      Console.ResetColor();
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice)
      {
        case 1:
          main.currentAdminUser.Add_User();
          validChoice = true;
          break;
        case 2: // hna kan fe error elfunction bta5d parameter
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("Enter the ID you want to block");
          Console.ResetColor();
          string IdToBlock = Console.ReadLine();
          main.currentAdminUser.BlockUser();
          validChoice = true;
          break;
        case 3:
          main.currentAdminUser.ChangeAnyUserStatus();
          validChoice = true;
          break;
        case 4:
          main.currentAdminUser.viewOnlineUsers();
          validChoice = true;
          break;
        case 5:
          main.currentAdminUser.ViewAllUsers();
          validChoice = true;
          break;
        case 6:
          main.currentAdminUser.ViewAllMessages();
          validChoice = true;
          break;
        case 7:
          main.currentAdminUser.DeleteMessages();
          validChoice = true;
          break;
        case 8:
          main.currentAdminUser.SendInPublicChat();
          validChoice = true;
          break;
        case 9:
          main.currentAdminUser.viewPublicChat();
          validChoice = true;
          break;
        case 10:
          main.currentAdminUser.LogOut();
          validChoice = true;
          main.Mode = "";
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Invalid choice. Please try again.");
          Console.ResetColor();
          validChoice = false;
          break;
      }
    }
  }

  public static void RegularMenu()
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Welcome " + main.currentRegularUser.GetName() + " (Regular User)");
    Console.ResetColor();
    Console.WriteLine("===================================");
    Console.WriteLine("1. View Online Users");
    Console.WriteLine("2. Send Text Message");
    Console.WriteLine("3. Send Voice Message");
    Console.WriteLine("4. Send Image Message");
    Console.WriteLine("5. React to a message ");
    Console.WriteLine("6. View Chat History");
    Console.WriteLine("7. Send To Public Chat");
    Console.WriteLine("8. View Public Chat");
    Console.WriteLine("9. Log Out");
    
    Console.WriteLine("===================================");

    bool validChoice = false;

    while (!validChoice){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Enter your choice: ");
      Console.ResetColor();
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice)
      {
        case 1:
          main.currentRegularUser.viewOnlineUsers();
          validChoice = true;
          break;
        case 2:
          main.currentRegularUser.SendTextMessage();
          validChoice = true;
          break;
        case 3:
          main.currentRegularUser.SendVoiceMessage();
          validChoice = true;
          break;
        case 4:
          main.currentRegularUser.SendImageMessage();
          validChoice = true;
          break;
        case 5:
          main.currentRegularUser.ReactToMessage();
          validChoice = true;
          break;
        case 6:
          main.currentRegularUser.ViewChatHistory();
          validChoice = true;
          break;
        case 7:
          main.currentRegularUser.SendInPublicChat();
          validChoice = true;
          break;
        case 8:
          main.currentRegularUser.viewPublicChat();
          validChoice = true;
          break;
        case 9:
          main.currentRegularUser.LogOut();
          validChoice = true;
          main.Mode = "";
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Invalid choice. Please try again.");
          Console.ResetColor();
          validChoice = false;
          break;
      }
    } 
  }

  public static void GuestMenu()
  {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Welcome " + main.currentGuestUser.GetName() + " (Guest User)");
    Console.ResetColor();
    Console.WriteLine("===================================");
    Console.WriteLine("1. View Online Users");
    Console.WriteLine("2. Send To Public Chat");
    Console.WriteLine("3. View Public Chat");
    Console.WriteLine("4. Log Out");
    Console.WriteLine("===================================");

    bool validChoice = false;

    while (!validChoice){
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Enter your choice: ");
      Console.ResetColor();
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice)
      {
        case 1:
          main.currentGuestUser.viewOnlineUsers();
          validChoice = true;
          break;
        case 2:
          main.currentGuestUser.SendInPublicChat();
          validChoice = true;
          break;
        case 3:
          main.currentGuestUser.viewPublicChat();
          validChoice = true;
          break;
        case 4:
          main.currentGuestUser.LogOut();
          validChoice = true;
          main.Mode = "";
          break;
        default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Invalid choice. Please try again.");
          Console.ResetColor();
          validChoice = false;
          break;
      }
    }
  }

  

  }
}
