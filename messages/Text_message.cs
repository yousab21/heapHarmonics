namespace messages{ class TextMessage : GeneralMessage

 {

  

 public TextMessage(string messageID, string sender, string receiver,string text):base( messageID, sender, receiver, text)

 {

 Text=text;

  

 }

 string Text;

  

 public string GettextMessage()

 {
 return Text;

 }

  
  
  
  

 }}