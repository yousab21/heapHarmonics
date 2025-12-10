using System;
using users;
using data;
using utils;

namespace messages{ 
  public class TextMessage : GeneralMessage
 {    
    private string Text;
     public TextMessage(string messageID, string sender, string receiver ,string text):base( messageID, sender, receiver){
     Text=text;// msh m7tag this wla eh?
 }

   public string GettextMessage(){
     return Text;
    }

    public void ViewTextMessage(){
      Console.WriteLine($"time [{Getime()}]");
      Console.WriteLine($"type : [Text Message]");
      Console.WriteLine($"message ID : [{GetmessageID()}]");
      Console.WriteLine($"from : [{Getsender()}]");
      Console.WriteLine($"to : [{Getreceiver()}]");
      Console.WriteLine($"message : \" {Text} \"");
      Console.WriteLine("================================");
    }
  }
 }
