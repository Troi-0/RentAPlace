namespace RentAPlace.Web.Controllers
{
    using System.Security.Claims;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RentAPlace.Services.Data;
    using RentAPlace.Web.ViewModels.Estate;

    public class EstateController : Controller
    {
        private readonly IEstateService estateService;

        public EstateController(IEstateService estateService)
        {
            this.estateService = estateService;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(EstateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            this.estateService.AsyncCreateEstate(input, userId);
            return this.Json("Yes");
        }
    }
}
