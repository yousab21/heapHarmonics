 using System;
 using users;
 using data;
 using utils;
 using messages;

 namespace messages
{
    public class GeneralMessage
    {
        protected string messageID;
        protected string sender;

        protected string receiver;
        public string emojis = "";
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
            // foreach (GeneralUser user in data.Data.allGeneralUsers)
            // {
            //     if (user.GetUserId() == sender)
            //     {
            //         return user.GetName();
            //     }
            // }
            // return "UNKOWN";
        }

        public string Getreceiver()
        {
         return receiver;
            // foreach (GeneralUser user in data.Data.allGeneralUsers)
            // {
            //     if (user.GetUserId() == receiver)
            //     {
            //         return user.GetName();
            //     }
            // }
            // return "UNKOWN";
        }

        public dynamic Gettime()
        {
            return timestap;
        }
                
        
    }
}
  


  
  
  



