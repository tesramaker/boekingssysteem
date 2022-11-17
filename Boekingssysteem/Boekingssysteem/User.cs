using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime lastLoginDate { get; set; }
        public Guid loginToken { get; set; }
        public bool cancellationInsurance { get; set; }
        
        public User(int id, string name, string password, DateTime lastLoginDate, Guid loginToken, bool cancellationInsurance)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.lastLoginDate = lastLoginDate;
            this.loginToken = loginToken;
            this.cancellationInsurance = cancellationInsurance;
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
    }
}
