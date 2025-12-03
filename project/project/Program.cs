using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        
        message e1=new message(1,"OMAR"," IAM WORKING ON MY PROJECT","AHMED");
        e1.getcontent();
        e1.getreceiver( );
        e1.getsender();
        e1.getime();
        e1.getmessageID();
        e1.displaymessage();
    }
}