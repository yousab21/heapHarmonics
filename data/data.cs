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
        public static List<string> allTextMessages = new List<VoiceMessage>();
        public static List<string> allTextMessages = new List<ImageMeessage>();


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
