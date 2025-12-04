 namespace messages{ class voiceMeessage : GeneralMassege

 {

  

 public voiceMeessage(string messageID, string sender, string receiver,int duration):base( messageID,  sender,  receiver,$"voice message: {duration}secounds")

 {

 DurationTime=duration;

  

 }

 int DurationTime;

  

 public int GetVoiceMessage()

 {

 return DurationTime;

 }

 }}

  