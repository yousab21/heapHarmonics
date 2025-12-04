namespace messages
{
    class GeneralMassege
    {
        string messageID;
        string sender;
        string contant;
        string receiver;
        dynamic timestap = DateTime.Now;

        public GeneralMassege(string messageID, string sender, string receiver, string contant)
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
            System.Console.WriteLine($"[{timestap}] [{sender}] to [{receiver}]: {contant}");
        }
    }
    class TextMeessage : GeneralMassege
    {

        public TextMeessage(string messageID, string sender, string receiver,string text):base( messageID,  sender,  receiver, text)
        {
            Text=text;

        }
        string Text;

        public string GettextMessage()
        {
            
            return Text;
        }




    }
    class ImageMeessage : GeneralMassege
    {
    

        public ImageMeessage(string messageID, string sender, string receiver,string path):base( messageID,  sender,  receiver,$" Image message: {path}")
        {
            Textpath=path;

        }
        string Textpath;

        public string GetImageMessage()
        {
            
            return Textpath;
        }




    }

    class voiceMeessage : GeneralMassege
    
    {

        public voiceMeessage(string messageID, string sender, string receiver,int duration):base( messageID,  sender,  receiver,$"voice message: {duration}secounds")
        {
            DurationTime=duration;

        }
        int  DurationTime;

        public int GetVoiceMessage()
        {
            
            return DurationTime;
        }
    }




}
