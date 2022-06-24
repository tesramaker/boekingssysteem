namespace BoekingssysteemAPI.Model
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime lastLoginDate { get; set; }
        public Guid loginToken { get; set; }

        public User(int id, string name, string password, DateTime lastLoginDate, Guid loginToken) : this(id, name, password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.lastLoginDate = lastLoginDate;
            this.loginToken = loginToken;
        }

        public User(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public User()
        {
            this.loginToken = Guid.Empty;
        }
    }
}
