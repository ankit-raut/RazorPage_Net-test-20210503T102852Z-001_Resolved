using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.RoomType
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public RoomTypeViewModel RoomType { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IRoomTypeService _roomTypeService;

        public CreateModel(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _roomTypeService.AddRoomTypeAsync(RoomType))
                {
                    Message = "Success";
                }
                return Redirect("./Index");
            }
            // Modelstate wasn't valid
            return Page();
        }
    }
}
