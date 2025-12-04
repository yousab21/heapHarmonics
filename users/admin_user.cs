using System;
using System.Collections.Generic;
using data;

namespace users
{
    public class AdminUser : GeneralUser
    {

        public AdminUser(int userId, string name): base(userId, name, "online"){}

        public void Add_User(GeneralUser newUser)
        {
            Data.allUsers.Add(newUser);
            Console.WriteLine($"{newUser.GetName()} added to the system");
        }

        public void DeleteMessages()
        {
            Data.allMessages.Clear();
            Console.WriteLine("All messages have been deleted from the system");
        }

        public void ViewAllUsers()
        {
            Console.WriteLine("----All Users----");
            foreach (GeneralUser u in Data.allUsers)
            {
                u.DisplayUserInfo();
                u.DisplayRole();
                Console.WriteLine("========================");
            }
        }

        public void ChangeAnyUserStatus(int userId, string newStatus)
        {
            GeneralUser user = Data.allUsers.Find(u => u.GetUserId() == userId);

            if (user != null)
            {
                user.SetStatus(newStatus);
                Console.WriteLine($"{user.GetName()}'s new status is {newStatus}");
            }
            else
            {
                Console.WriteLine("there is no user with that id");
            }
        }

        public void BlockUser(int userId)
        {
            GeneralUser user = Data.allUsers.Find(u => u.GetUserId() == userId);

            if (user != null)
            {
                user.SetStatus("Blocked");
                Console.WriteLine($"{user.GetName()} has been blocked");
            }
            else
            {
                Console.WriteLine("there is no user with that id");
            }
        }
    }
}
