 namespace messages
{
    public class GeneralMessage
    {
        protected string messageID;
        protected string sender;

        protected string receiver;
        dynamic timestap = DateTime.Now;

        public GeneralMessage(string messageID, string sender, string receiver)
        {
            this.messageID = messageID;

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

        public dynamic Getime()
        {
            return timestap;
        }
        
    }
}
  


  
  
  



