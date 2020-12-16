namespace RentAPlace.Web.ViewModels.Estate
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    public class EstateInputModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        [MaxLength(500)]
        [MinLength(50)]
        public string Description { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public double Rent { get; set; }

        [Range(1, 120)]
        [Required]
        [Display(Name = "Count of rooms")]
        public int CountOfRooms { get; set; }

        [Required]
        [MinLength(3)]
        public string Location { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<string> UtilitiesNames { get; set; }
    }
}
