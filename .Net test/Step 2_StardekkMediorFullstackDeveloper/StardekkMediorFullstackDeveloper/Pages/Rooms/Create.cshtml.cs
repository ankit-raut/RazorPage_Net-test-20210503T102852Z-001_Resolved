using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.Rooms
{
    public class CreateModel : PageModel
    {
        private readonly IRoomService _roomService;

        [BindProperty]
        public RoomViewModel Room { get; set; }
        [BindProperty]
        public SelectList Options { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public CreateModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async void OnGet()
        {
            // return Page();
            Room = await _roomService.GetRoomByIdAsync(0);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _roomService.AddRoomAsync(Room))
                {
                    Message = "Success";
                }
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
