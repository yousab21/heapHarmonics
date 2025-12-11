using System;
using messages;
using data;
using utils;

namespace users
{
  
    public class RegularUser : GeneralUser
    {
        public RegularUser(string userId, string name, string status = "OFFLINE")
            : base(userId, name, status)
    {
    }

    public void SendTextMessage()
    {
        TextMessage newTextMessage;
        string receiverID;
        string messageText;

        Console.WriteLine("enter the id of the user you want to send message to : ");
        receiverID = Console.ReadLine();
        Console.WriteLine("enter your text message : ");
        messageText = Console.ReadLine();

        foreach (users.GeneralUser user in Data.allGeneralUsers)
        {
            if (user.GetUserId() == receiverID)
            {
                Console.WriteLine($"User found: {user.GetName()}");
                break;
                return;
            }
        }

        newTextMessage = new TextMessage($"TM{Data.allTextMessages.Count + 1}", this.GetUserId(), receiverID, messageText);
        Data.allMessages.Add(newTextMessage);
        Data.allTextMessages.Add(newTextMessage);
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Text message sent successfully.");
        Console.ResetColor();
        Console.WriteLine("===============================");
        Console.WriteLine();
    }
        public void SendVoiceMessage()
    {
        VoiceMessage newVoiceMessage;
        string receiverID;
        int VoiceLeanth;

        Console.WriteLine("enter the id of the user you want to send message to : ");
        receiverID = Console.ReadLine();
        Console.WriteLine("enter the duration of your Voice message : ");
        VoiceLeanth = Convert.ToInt32(Console.ReadLine());

        foreach (users.GeneralUser user in Data.allGeneralUsers)
        {
            if (user.GetUserId() == receiverID)
            {
                Console.WriteLine($"User found: {user.GetName()}");
                break;
                return;
            }
        }

        newVoiceMessage = new VoiceMessage($"VM{Data.allVoiceMessages.Count + 1}", this.GetUserId(), receiverID, VoiceLeanth);
        Data.allMessages.Add(newVoiceMessage);
        Data.allVoiceMessages.Add(newVoiceMessage);
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Voice message sent successfully.");
        Console.ResetColor();
        Console.WriteLine("===============================");
        Console.WriteLine();
    }
        public void SendImageMessage()
    {
        ImageMessage newImageMessage;
        string receiverID;
        string Path;

        Console.WriteLine("enter the id of the user you want to send message to : ");
        receiverID = Console.ReadLine();
        Console.WriteLine("enter the path the image you want to send : ");
        Path = Console.ReadLine();

        foreach (users.GeneralUser user in Data.allGeneralUsers)
        {
            if (user.GetUserId() == receiverID)
            {
                Console.WriteLine($"User found: {user.GetName()}");
                break;
                return;
            }
        }

        newImageMessage = new ImageMessage($"IM{Data.allImageMessages.Count + 1}", this.GetUserId(), receiverID, Path);
        Data.allMessages.Add(newImageMessage);
        Data.allImageMessages.Add(newImageMessage);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Image message sent successfully.");
        Console.ResetColor();
        Console.WriteLine("===============================");
        Console.WriteLine();
    }

    public void ViewChatHistory()
    {
        Console.WriteLine($"Chat history for user: {this.GetName()}");
        Console.WriteLine("=======================================");
        Console.WriteLine("Text Messages:");
        Console.WriteLine(".......................................");
        foreach ( TextMessage TM in Data.allTextMessages)
        {
            if (TM.Getsender() == this.GetUserId() || TM.Getreceiver() == this.GetUserId())
            {
                TM.ViewTextMessage();
            }
        }
        Console.WriteLine("=======================================");
        Console.WriteLine("Voice Messages:");
        Console.WriteLine(".......................................");
        foreach ( VoiceMessage VM in Data.allVoiceMessages)
        {
            if (VM.Getsender() == this.GetUserId() || VM.Getreceiver() == this.GetUserId())
            {
                VM.ViewVoiceMessage();
            }
        }
        Console.WriteLine("=======================================");
        Console.WriteLine("Image Messages:");
        Console.WriteLine(".......................................");
        foreach ( ImageMessage IM in Data.allImageMessages)
        {
            if (IM.Getsender() == this.GetUserId() || IM.Getreceiver() == this.GetUserId())
            {
                IM.ViewImageMessage();
            }

        }
    }
    public void DeleteMyMessage(string messageId)
        {
            GeneralMessage required_message = null;
            foreach(GeneralMessage obj in Data.allMessages)
            {
                if (obj.GetmessageID()== messageId && obj.Getsender() == this.GetUserId())
                {
                    required_message = obj;
                    break;
                }
            }
            if(required_message == null)
            {
                System.Console.WriteLine("Message not found or you are not the sender :(");
                return; // 3l4an mykml4 l7d ma ytb3 "Your message deleted successfully :)" 
            }

            Data.allMessages.Remove(required_message);
            Data.allTextMessages.Remove(required_message as TextMessage);
            Data.allImageMessages.Remove(required_message as ImageMessage);
            Data.allVoiceMessages.Remove(required_message as VoiceMessage);

            System.Console.WriteLine(" Your message deleted successfully :) ");
        }

       
    
}
}
