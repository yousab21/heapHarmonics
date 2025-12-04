namespace users
{
  
    public class RegularUser : GeneralUser
    {
        public RegularUser(string userId, string name, string status = "OFFLINE")
            : base(userId, name, status)
        {
        }
    }

}