
using System;
using System.Threading;
using messages;
using users;
using utils;
class main
{
  public static void Main(string[] args)
  {
    ConsoleUtils.Refresh();
    AdminUser admin = new AdminUser("u0001", "Alice");

    admin.Add_User();
    admin.Add_User();
    admin.Add_User();

    admin.ViewAllUsers();

  }
}