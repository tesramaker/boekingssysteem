﻿using BoekingssysteemAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BoekingssysteemAPI.DbConnection
{
    public class BoekingssysteemContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Plane> Plane { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Vacation> Vacation { get; set; }


        public BoekingssysteemContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetConnectionString()
        { 
            return _connectionString; 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(_connectionString);
        }


    }
}
