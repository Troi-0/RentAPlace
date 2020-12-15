namespace RentAPlace.Data.Models
{
    using RentAPlace.Data.Common.Models;

    public class EstateUtilities : BaseModel<int>
    {
        public int UtilityId { get; set; }

        public Utility Utility { get; set; }

        public int EstateId { get; set; }

        public Estate Estate { get; set; }
    }
}
