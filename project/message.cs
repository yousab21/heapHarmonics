class message
{
    int messageID;
    string senderID;
     string contant;
     string receiverID;
      dynamic timestap=DateTime.Now;

      public message( int messageID,string sender,string contant, string receiver)
    {
        this.messageID=messageID;
        this.contant=contant;
        this.senderID=sender;
        this.receiverID=receiver;


    }

      public int getmessageID()
    {
        return messageID;
    }
    public string getsender()
    {
        
        return senderID;
    }
    public string getreceiver()
    {
        return receiverID;
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
        System.Console.WriteLine($"[{timestap}] {senderID} : {contant}");
    }

}