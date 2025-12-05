using System;
using System.Collections.Generic;
using users;
using messages;

namespace data
{
    public static class Data
    {
        // Static members
        public static List<GeneralUser> allGeneralUsers = new List<GeneralUser>();
        public static List<RegularUser> allRegularUsers = new List<RegularUser>();
        public static List<GuestUser> allGuestUsers = new List<GuestUser>();
        public static List<AdminUser> allAdminUsers = new List<AdminUser>();
        public static List<string> allTextMessages = new List<TextMessage>();
        public static List<string> allVoiceMessages = new List<VoiceMessage>();//msh mafrod allVoiceMessages
        public static List<string> allImageMessages = new List<ImageMeessage>();//msh mafrod allImageMessages
        public static List<GeneralMessage> allMessages = new List<GeneralMessage>();
        allMessages.AddRange(TextMessges());
        allMessages.AddRange(ImageMessges());
        allMessages.AddRange(VoiceMessges());
        // da ykon list gwaha kol elmo7twa bta3 el lists b7eth ana 3ande lma a3ml delete ydoar hna eh rayko


        // Static methods
        // public static void AddMessage(string message)
        // {
        //     allMessages.Add(message);
        // }

        // public static List<string> GetAllMessages()
        // {
        //     return allMessages;
        // }
    }
}
