using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Railway_Reservation.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Ticket_Id { get; set; }

        [ForeignKey("Reservation")]
       public int Res_Id { get; set; }
        public Reservation Reservation { get; set; }

        public Double Amount { get; set; }

        public  string DateOfJourney { get; set; }

    }
}