namespace RentAPlace.Services.Data
{
    using RentAPlace.Web.ViewModels.Estate;

    public interface IEstateService
    {
        void AsyncCreateEstate(EstateInputModel input, string userId);
    }
}
