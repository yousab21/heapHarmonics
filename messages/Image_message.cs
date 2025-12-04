 namespace message{class ImageMeessage : GeneralMassege

{

  

 public ImageMeessage(string messageID, string sender, string receiver,string path):base( messageID,  sender,  receiver,$" Image message: {path}")

 {
 Textpath=path;

  

 }

 string Textpath;

  

 public string GetImageMessage()
 {

 return Textpath;

}

 }}
