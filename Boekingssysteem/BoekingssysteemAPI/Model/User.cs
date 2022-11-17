namespace BoekingssysteemAPI.Model
{
    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? password { get; set; }
        public DateTime lastLoginDate { get; set; }
        public Guid loginToken { get; set; }
        public bool cancellationInsurance { get; set; }
        //TODO AccessLevel not yet implemented, perhaps for future version (customer, company, admin etc), not yet implemented in the DB
        //public int accessLevel { get; set; }

        public User(int id, string name, string password, DateTime lastLoginDate, Guid loginToken, bool cancellationInsurance)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.lastLoginDate = lastLoginDate;
            this.loginToken = loginToken;
            this.cancellationInsurance = cancellationInsurance;
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

        public User(int id, Guid logoinToken)
        {
            this.id = id;
            this.loginToken = loginToken;

        }

        public User()
        {
            this.loginToken = Guid.Empty;
        }
    }
}
