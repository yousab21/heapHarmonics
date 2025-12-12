using System;
using users;
using data;
using utils;

 namespace messages{
public class VoiceMessage : GeneralMessage{
    private int DurationTime;
    public VoiceMessage(string messageID, string sender, string receiver,int duration):base( messageID,  sender,  receiver) {
    DurationTime=duration;
    }
    public int GetVoiceMessage(){
    return DurationTime;
    }

    public void ViewVoiceMessage(){
    Console.WriteLine($"time[{Getime()}]");
    Console.WriteLine($"type : [Voice Message]");
    Console.WriteLine($"message ID : [{GetmessageID()}]");
    Console.WriteLine($"from : [{Getsender()}]");
    Console.WriteLine($"to : [{Getreceiver()}]");
    Console.WriteLine($"Voice duration : \" {DurationTime} \"");
    Console.WriteLine($"emojis : [{emojis}]");
    Console.WriteLine("================================");
    }

  }
}

  