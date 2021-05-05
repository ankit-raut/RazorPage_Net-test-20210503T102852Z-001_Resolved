using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public AmenityViewModel ViewModel { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IAmenityService _amenityService;

        public AddModel(IAmenityService amenityService)
        {
            _amenityService = amenityService;
        }

        public void OnGet()
        {
            TempData["type"] = ViewData["type"] ;
            TempData["Message"] = ViewData["Message"] ;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _amenityService.AddAmenityAsync(ViewModel))
                {
                    TempData["type"] = ViewData["type"] = "success";
                    TempData["Message"] = ViewData["Message"] = "Success";
                }
                return Redirect("/amenities/list");
            }
            // Modelstate wasn't valid
            return Page();
        }
    }
}