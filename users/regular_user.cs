namespace users
{
  
    public class RegularUser : GeneralUser
    {
        public RegularUser(int userId, string name, string status = "OFFLINE")
            : base(userId, name, status)
        {
        }
    }

}