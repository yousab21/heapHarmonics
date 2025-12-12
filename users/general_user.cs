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
    
    public void ReactToMessage()
        {
            System.Console.WriteLine("Enter the ID of the message u want to react to");
            string messageid = Console.ReadLine();


            System.Console.WriteLine("===Choose an Emoji");
            System.Console.WriteLine("1.♥️");
            System.Console.WriteLine("2.😂");
            System.Console.WriteLine("3.👍🏻");
            System.Console.WriteLine("4.😭");
            System.Console.WriteLine("5.😡");

            int choice = Convert.ToInt32(Console.ReadLine());
            string emoji="";

            switch (choice)
            {
                case 1:
                emoji = "👍";
                break;

                case 2:
                emoji = "♥️";
                break;

                case 3:
                emoji = "😂";
                break;

                case 4:
                emoji = "😭";
                break;

                case 5:
                emoji = "😡";
                break;
                default:
                System.Console.WriteLine("Invalid choice");
                return;
            }

            foreach (GeneralMessage message in Data.allMessages)
            {
                if(message.GetmessageID() == messageid)
                {
                    message.emojis += emoji;
                    break;
                }
                else
                {
                    System.Console.WriteLine("Message not found :(");
                    return;
                }
            }


            System.Console.WriteLine($"You reacted to message {messageid} with {emoji}");
        }

}
}




