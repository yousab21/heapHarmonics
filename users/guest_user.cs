namespace users
{
  
    public class GuestUser : GeneralUser
    {
        public GuestUser(string userId, string name, string status = "OFFLINE")
            : base(userId, name, status)
        {
        }
    }

}