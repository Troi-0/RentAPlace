namespace RentAPlace.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using RentAPlace.Data.Common.Models;

    public class Booking : BaseDeletableModel<int>
    {

        // Todo: only user that booked the place can see it
        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public DateTime BookedFrom { get; set; }

        [Required]
        public DateTime BookedTo { get; set; }

        [Required]
        public int EstateId { get; set; }

        public virtual Estate Estate { get; set; }
    }
}
