using System;
using System.Collections.Generic;
using users;
using messages;

namespace data
{
    public static class Data
    {
        // Static members
        public static List<GeneralUser> allUsers = new List<GeneralUser>();
        public static List<string> allMessages = new List<string>();

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
