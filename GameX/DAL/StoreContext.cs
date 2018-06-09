using GameX.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.DAL
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
           
        }
        public DbSet<Events> Events { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<EventParticipants> EventParticipants { get; set; }
    }
}
