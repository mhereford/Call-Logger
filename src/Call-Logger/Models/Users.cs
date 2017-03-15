namespace Call_Logger.Models
{
    public class Users
    {
        public enum UserList
        {
            gsherman = 1,
            cashby = 2,
            mhereford = 3
        }

        public Users(UserList userList, string name = null)
        {
            Id = (int)userList;

            LoginID = LoginID ?? userList.ToString();
        }

        public int Id { get; set; }

        public string LoginID { get; set; }
    }
}
