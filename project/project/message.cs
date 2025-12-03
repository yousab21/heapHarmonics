class message
{
    int messageID;
    string sender;
     string contant;
     string receiver;
      dynamic timestap=DateTime.Now;

      public message( int messageID,string sender,string contant, string receiver)
    {
        this.messageID=messageID;
        this.contant=contant;
        this.sender=sender;
        this.receiver=receiver;


    }

      public int getmessageID()
    {
        return messageID;
    }
    public string getsender()
    {
        
        return sender;
    }
    public string getreceiver()
    {
        return receiver;
    }
    public string getcontent()
    {
        return contant;
    }
    public dynamic getime()
    {
        return timestap;
    }
    public void displaymessage()
    {
        System.Console.WriteLine($"[{timestap}] {sender} : {contant}");
    }

}