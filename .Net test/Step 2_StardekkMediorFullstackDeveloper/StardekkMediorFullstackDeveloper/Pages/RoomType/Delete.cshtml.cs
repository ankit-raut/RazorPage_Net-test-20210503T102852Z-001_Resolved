using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.RoomType
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public RoomTypeViewModel RoomType { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IRoomTypeService _roomTypeService;

        public DeleteModel(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RoomType = await _roomTypeService.GetRoomTypeByIdAsync(id ?? 0);
            if (RoomType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (await _roomTypeService.DeleteRoomTypeAsync(id ?? 0))
            {
                Message = "Success";
            }
            return RedirectToPage("./Index");
        }
    }
}

