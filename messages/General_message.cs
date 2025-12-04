 namespace messages
{
    class GeneralMassege
    {
        string messageID;
        string sender;
        string content;
        string receiver;
        dynamic timestap = DateTime.Now;

        public GeneralMassege(string messageID, string sender, string content, string receiver)
        {
            this.messageID = messageID;
            this.content = content;
            this.sender = sender;
            this.receiver = receiver;
        }

        public string GetmessageID()
        {
            return messageID;
        }

        public string Getsender()
        {
            return sender;
        }

        public string Getreceiver()
        {
            return receiver;
        }

        public string Getcontent()
        {
            return content;
        }

        public dynamic Getime()
        {
            return timestap;
        }

        public void Displaymessage()
        {
            System.Console.WriteLine($"[{timestap}] {sender} : {content}");
        }
    }
      

 }

  


  
  
  



