namespace RentAPlace.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentAPlace.Data.Common.Models;

    public class Estate : BaseDeletableModel<int>
    {
        public Estate()
        {
            this.EstatesUtilities = new HashSet<EstateUtilities>();
            this.Images = new HashSet<Image>();
            this.Bookings = new HashSet<Booking>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int Rating { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public double Rent { get; set; }

        [Range(1, 120)]
        [Required]
        public int CountOfRooms { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public int LocationId { get; set; }

        public Location Location { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<EstateUtilities> EstatesUtilities { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
