using System;
using System.Net.Sockets;
using Microsoft.Win32.SafeHandles;

namespace OnlineChat
{

public class User
{
    private int userId;
    private string name;
    private string Status;

    public User( int userId , string name ,string status ="OFFLINE")
    {
        this.userId = userId;
        this.name = name;
        this.Status = status;
    }
    public int GetUserId()
    {
        return userId;
    }
    public string GetName()
    {
        return name;
    }
    public string GetStatus()
    {
        return Status;
    }
    public void SetStatus(string newstatu)
    {
        Status = newstatu; // online or offline maybe busy or anything 
    }
    public void LogIn()
    {
        SetStatus("ONLINE");
        System.Console.WriteLine($"{name} logged in ");
    }
    public void LogOut()
    {
        SetStatus("OFFLINE");
        System.Console.WriteLine($"{name} logged out ");
    }
    public void DisplayUserInfo()
    {
        System.Console.WriteLine("----User Info----");
        System.Console.WriteLine($"ID: {userId}");
        System.Console.WriteLine($"User Name: {name}");
        System.Console.WriteLine($"User statu: {Status}");
    }
    public virtual void DisplayRole()
    {
        System.Console.WriteLine("Role: General User");
    }

}
public class Admin : User
{
    private List<User> allUsers;
    private List<string> allMessages;
  
    public Admin(int userId,string name,List<User> users,List<string> messages):base(userId,name,"online")
        {
            allMessages = messages;
            allUsers = users;
        }
    public void Add_User(User newUser)
        {
            allUsers.Add(newUser);
            System.Console.WriteLine($"{newUser.GetName()} added to the system");
        }
    public void DeleteMessages()
        {
            allMessages.Clear();
            System.Console.WriteLine("All messages have been deleted from the system");
        }
    public void ViewAllUsers()
        {
            System.Console.WriteLine("----All Users----");
            foreach (User u in allUsers)
            {
                u.DisplayUserInfo();
                u.DisplayRole();
                System.Console.WriteLine("========================");
            }
        }
    public void ChangeAnyUserStatus(int userId ,string newStatu)
        {
            User user = allUsers.Find(u => u.GetUserId() == userId);
            if (user != null)
            {
                user.SetStatus(newStatu);
                System.Console.WriteLine($"{user.GetName}'s new statu is {newStatu}");
            }
            else
            {
                System.Console.WriteLine("there is no user with that id");
            }
        }
    public void BlockUser (int userId)
        {
            User user = allUsers.Find(u => u.GetUserId() == userId);
            if (user != null)
            {
                user.SetStatus("Blocked");
                System.Console.WriteLine($"{user.GetName} has been blocked");
            }
            else
            {
                System.Console.WriteLine("there is no user with that id");
            }
        }
}
}
