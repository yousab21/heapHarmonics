using System;
using users;
using data;
using utils;

namespace messages {
    class ImageMeessage : GeneralMessage
    {
        private string ImagePath;
        public ImageMeessage(string messageID, string sender, string receiver,string path):base( messageID,  sender,  receiver)
        {
            ImagePath=path;
        }
        public string GetImageMessage()
        {
            return ImagePath;
        }

        public void ViewVoiceMessage(){
        Console.WriteLine($"time[{Getime()}]");
        Console.WriteLine($"type : [Image Message]");
        Console.WriteLine($"message ID : [{GetmessageID()}]");
        Console.WriteLine($"from : [{Getsender()}]");
        Console.WriteLine($"to : [{Getreceiver()}]");
        Console.WriteLine($"Image path : \" {ImagePath} \"");
        Console.WriteLine("================================");
        }


    }
}