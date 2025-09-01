namespace TheDataLayer_For_Project.Models.Users
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
    }
}
