using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper
{
    public class ListModel : PageModel
    {
        public List<AmenityViewModel> Amenities { get; set; }

        private readonly IAmenityService _amenityService;

        public ListModel(IAmenityService amenityService)
        {
            _amenityService = amenityService;
        }

        public async Task OnGetAsync()
        {
            await InitAsync();
            TempData["type"] = ViewData["type"];
            TempData["Message"] = ViewData["Message"];
        }

        private async Task InitAsync()
        {
            this.Amenities = await _amenityService.GetAllAmenities();
        }
    }
}