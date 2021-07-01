using System;
using Microsoft.EntityFrameworkCore;
using vacationPlanner.ServiceLayer.Models;

namespace vacationPlanner.ServiceLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
