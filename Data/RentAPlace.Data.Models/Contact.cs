namespace RentAPlace.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RentAPlace.Data.Common.Models;

    public class Contact : BaseDeletableModel<int>
    {
        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }
    }
}
