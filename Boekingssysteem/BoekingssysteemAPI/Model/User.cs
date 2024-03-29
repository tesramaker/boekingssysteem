﻿namespace BoekingssysteemAPI.Model
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime? lastLoginDate { get; set; }
        public Guid? loginToken { get; set; }
        public bool? cancellationInsurance { get; set; }
    }
}
