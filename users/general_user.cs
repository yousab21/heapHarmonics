using System;


namespace users
{

public class GeneralUser
{
    private int userId;
    private string name;
    private string Status;

    public GeneralUser( int userId , string name ,string status ="OFFLINE")
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
    public void SetStatus(string newstatus)
    {
        Status = newstatus; // online or offline maybe busy or anything 
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

}
