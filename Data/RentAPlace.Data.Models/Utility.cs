namespace RentAPlace.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using RentAPlace.Data.Common.Models;
    using RentAPlace.Data.Models.Enums;

    public class Utility : BaseDeletableModel<int>
    {
        public Utility()
        {
            this.PropertyUtilities = new HashSet<EstateUtilities>();
        }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public Condition Condition { get; set; }

        public Quality Quality { get; set; }

        public virtual ICollection<EstateUtilities> PropertyUtilities { get; set; }
    }
}
