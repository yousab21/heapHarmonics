using System;
using messages;
using data;
using utils;


namespace users
{

public class GeneralUser
{
    protected string userId;
    protected string name;
    protected string Status;
    protected string Role;

    public GeneralUser( string userId = "0" , string name = "UNKOWN" ,string status ="OFFLINE", string Role="UNKOWN")
    {
        this.userId = userId;
        this.name = name;
        this.Status = status;
        this.Role = Role;
    }
    public string GetUserId()
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
    public string GetRole()
    {
        return Role;
    }
    public void SetUserId(string newID)
    {
        userId = newID;
    }
    public void SetName(string newName)
    {
        name = newName;
    }
    public void SetStatus(string newstatus)
    {
        Status = newstatus; 
    }
    public void SetRole(string newRole)
    {
        Role = newRole;
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
        System.Console.WriteLine($"User ID: {userId}");
        System.Console.WriteLine($"User Name: {name}");
        System.Console.WriteLine($"User status: {Status}");
        System.Console.WriteLine($"User Role: {Role}");

    }

    public void SendInPublicChat()
        {
            TextMessage newTextMessage;
            string messageText;

            Console.WriteLine("enter your text message for the Public Chat: ");
            messageText = Console.ReadLine();

            newTextMessage = new TextMessage($"PC{Data.PublicChat.Count + 1}", this.GetUserId(), "PublicChat", messageText);
            Data.PublicChat.Add(newTextMessage);
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Text message sent successfully to Public Chat.");
            Console.ResetColor();
            Console.WriteLine("===============================");
            Console.WriteLine();
        }
    
    public void viewPublicChat()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("---- Public Chat Messages ----");
        Console.ResetColor();
        foreach ( TextMessage PC in Data.PublicChat)
            {
                PC.ViewTextMessage();
            }
        Console.WriteLine("===================================");

}

public void viewOnlineUsers()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("---- Online Users ----");
    Console.ResetColor();
    foreach ( GeneralUser user in Data.allGeneralUsers)
        {
            if (user.GetStatus() == "ONLINE")
            {
                Console.WriteLine($"User ID: {user.GetUserId()}");
                Console.WriteLine($"User Name: {user.GetName()}");
                Console.WriteLine("----------------------");
            }
        }
    Console.WriteLine("===================================");
}

}
}


