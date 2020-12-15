namespace RentAPlace.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using RentAPlace.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Extension { get; set; }

        // The contents of the image is in the file system
        public string RemoteImageUrl { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int? EstateId { get; set; }

        public Estate Estate { get; set; }
    }
}
