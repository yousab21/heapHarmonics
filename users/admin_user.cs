using System;
using System.Collections.Generic;
using data;
using users;
using messages;
using utils;

namespace users
{
    public class AdminUser : GeneralUser
    {

        public AdminUser(int userId, string name, string status = "ONLINE"):base( userId, name, status)
            {
            this.SetRole("Admin");
            }
        
        
        public void Add_User()
        {
            // ConsoleUtils.Refresh();
            int role;
            int id;
            string name;
            string Role;
            GeneralUser newUser;

            Console.WriteLine("what type of user do you want to add?");
            Console.WriteLine("1. Regular User");
            Console.WriteLine("2. Admin User");
            Console.WriteLine("3. Guest User");
            role = Convert.ToInt32(Console.ReadLine());

            switch (role)
            {
                case 1:
                    newUser = new RegularUser("temp", "temp");
                    newUser.SetRole("Regular User");
                    break;
                case 2:
                    newUser = new AdminUser("temp", "temp");
                    newUser.SetRole("Admin User");
                    break;
                case 3:
                    newUser = new GuestUser("temp", "temp");
                    newUser.SetRole("Guest User");
                    break;
                default:
                    Console.WriteLine("Invalid role selected.");
                    return;
            }

            Console.WriteLine("enter the new user's ID : ");
            id = Console.ReadLine();                        // hna hytl3 error 3lshan el casting bs msh 3arf azbthh
            newUser.SetUserId(id);
            Console.WriteLine("enter the new user's Name : ");
            name = Console.ReadLine();
            newUser.SetName(name);

            switch (role)
            {
                case 1:
                    Data.allRegularUsers.Add((RegularUser)newUser);
                    Data.allGeneralUsers.Add((RegularUser)newUser);
                    break;
                case 2:
                    Data.allAdminUsers.Add((AdminUser)newUser);
                    Data.allGeneralUsers.Add((AdminUser)newUser);
                    break;
                case 3:
                    Data.allGuestUsers.Add((GuestUser)newUser);
                    Data.allGeneralUsers.Add((GuestUser)newUser);
                    break;
                default:
                    Console.WriteLine("Invalid role selected.");
                    return;
            }
            ConsoleUtils.ClearLines(5);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{newUser.GetName()} added as {newUser.GetRole()} to the system");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void DeleteMessages()
        {
            Data.allMessages.Clear();
            Console.WriteLine("All messages have been deleted from the system");
        }
        public void DeleteTextMessages()
        {

            Data.allTextMessages.Clear();
            Console.WriteLine("All text messages have been deleted from the system");
        }
        public void DeleteVoiceMessages()
        {

            Data.allVoiceMessages.Clear();
            Console.WriteLine("All voice messages have been deleted from the system");
        }
        public void DeleteImageMessages()
        {

            Data.allImageMessages.Clear();
            Console.WriteLine("All image messages have been deleted from the system");
        }
        // momken kda bardo lw 3ayz tms7 no3 mo7adad

        public void ViewAllUsers()
        {   
            ConsoleUtils.Refresh();
            Console.WriteLine("----All Users----");
            foreach ( AdminUser AU in Data.allAdminUsers)
            {
                AU.DisplayUserInfo();
                Console.WriteLine("========================");
            }
            foreach ( RegularUser RU in Data.allRegularUsers)
            {
                RU.DisplayUserInfo();
                Console.WriteLine("========================");
            }
            foreach ( GuestUser GU in Data.allGuestUsers)
            {
                GU.DisplayUserInfo();
                Console.WriteLine("========================");
            }
        }

        public void ViewAllMessages()
        {
            ConsoleUtils.Refresh();
            Console.WriteLine("----All Messages----");
            foreach ( TextMessage TM in Data.allTextMessages)
            {
                TM.ViewTextMessage();
            }
            foreach ( VoiceMessage VM in Data.allVoiceMessages)
            {
                VM.ViewVoiceMessage();
            }
            foreach ( ImageMeessage IM in Data.allImageMessages)
            {
                IM.ViewImageMessage();
            }
        }

        public void ChangeAnyUserStatus(int userId, string newStatus)
        {
            GeneralUser user = Data.allGeneralUsers.Find(u => u.GetUserId() == userId);

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

        // public void BlockUser(int userId)
        // {
        //     GeneralUser user = Data.allUsers.Find(u => u.GetUserId() == userId);

        //     if (user != null)
        //     {
        //         user.SetStatus("Blocked");
        //         Console.WriteLine($"{user.GetName()} has been blocked");
        //     }
        //     else
        //     {
        //         Console.WriteLine("there is no user with that id");
        //     }
        // }
    }
}
