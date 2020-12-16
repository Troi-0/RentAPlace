namespace RentAPlace.Services.Data
{
    using System.Linq;

    using RentAPlace.Data.Common.Repositories;
    using RentAPlace.Data.Models;
    using RentAPlace.Web.ViewModels.Estate;

    public class EstateService : IEstateService
    {
        private readonly IDeletableEntityRepository<Estate> estateRepository;
        private readonly IDeletableEntityRepository<Location> locationRepository;
        private readonly IDeletableEntityRepository<Utility> utilityRepository;

        public EstateService(
            IDeletableEntityRepository<Estate> estateRepository,
            IDeletableEntityRepository<Location> locationRepository,
            IDeletableEntityRepository<Utility> utilityRepository)
        {
            this.estateRepository = estateRepository;
            this.locationRepository = locationRepository;
            this.utilityRepository = utilityRepository;
        }

        public async void AsyncCreateEstate(EstateInputModel input, string userId)
        {
            var estate = new Estate
            {
                Name = input.Name,
                Description = input.Description,
                Rent = input.Rent,
                CountOfRooms = input.CountOfRooms,
                UserId = userId,
            };


            // Location
            var location = this.locationRepository.All().FirstOrDefault(x => x.Name == input.Location);
            if (location == null)
            {
                location = new Location
                {
                    Name = input.Location,
                };
            }

            estate.Location = location;

            // Utilities
            if (input.UtilitiesNames != null)
            {
                foreach (var utilityName in input.UtilitiesNames)
                {
                    var utility = this.utilityRepository.All().FirstOrDefault(x => x.Name == utilityName);
                    if (utility == null)
                    {
                        utility = new Utility
                        {
                            Name = utilityName,
                        };
                    }

                    estate.EstatesUtilities.Add(new EstateUtilities
                    {
                        Estate = estate,
                        Utility = utility,
                    });
                }
            }

            using (this.estateRepository)
            {
                await this.estateRepository.AddAsync(estate);
                await this.estateRepository.SaveChangesAsync();
            }
        }
    }
}
