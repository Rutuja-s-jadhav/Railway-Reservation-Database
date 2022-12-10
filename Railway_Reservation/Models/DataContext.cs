using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Railway_Reservation.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TrainDetails> TrainDetails { get; set; }

    }
}