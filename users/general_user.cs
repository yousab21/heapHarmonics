using System;


namespace users
{

public class GeneralUser
{
    protected string userId;
    protected string name;
    protected string Status;
    protected string Role;

    public GeneralUser( string userId = "UNKOWN" , string name = "UNKOWN" ,string status ="OFFLINE", string Role="UNKOWN")
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

}

}
