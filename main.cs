
using System;
using System.Threading;
using messages;
using users;
using utils;
class main
{
  public static void Main(string[] args)
  {
    AdminUser admin = new AdminUser(1, "Alice");
    RegularUser user1 = new RegularUser(2, "Bob");
    RegularUser user2 = new RegularUser(3, "Charlie");
    
    admin.Add_User(user1);
    admin.Add_User(user2);

    admin.ViewAllUsers();
  }
}