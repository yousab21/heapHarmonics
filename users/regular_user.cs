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

    }

}