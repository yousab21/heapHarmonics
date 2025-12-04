 namespace messages
{
    class GeneralMassege
    {
        string messageID;
        string sender;
        string contant;
        string receiver;
        dynamic timestap = DateTime.Now;

        public GeneralMassege(string messageID, string sender, string contant, string receiver)
        {
            this.messageID = messageID;
            this.contant = contant;
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
            return contant;
        }

        public dynamic Getime()
        {
            return timestap;
        }

        public void Displaymessage()
        {
            System.Console.WriteLine($"[{timestap}] {sender} : {contant}");
        }
    }
}
