using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Linq;
using System.Threading.Tasks;


namespace StardekkMediorFullstackDeveloper.Pages.Rooms
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public RoomViewModel Room { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IRoomService _roomService;

        public EditModel(IRoomService roomService)
        {
            _roomService = roomService;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Room = await _roomService.GetRoomByIdAsync(id ?? 0);
            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (await _roomService.UpdateRoomAsync(Room))
            {
                Message = "Success";
            }
            if (Room == null)
            {
                return NotFound();
            }
            //try
            //{

            //    await db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    //if (!RoomExists(Room.Id))
            //    //{
            //    //    return NotFound();
            //    //}
            //    //else
            //    //{
            //    //    throw;
            //    //}
            //}

            return RedirectToPage("./Index");
        }

        //private bool RoomExists(int id)
        //{
        //    //return db.Rooms.Any(e => e.Id == id);
        //}
    }
}
