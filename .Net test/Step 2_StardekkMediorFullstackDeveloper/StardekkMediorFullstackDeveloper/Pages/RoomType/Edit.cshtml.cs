using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.RoomType
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public RoomTypeViewModel RoomType { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IRoomTypeService _roomTypeService;

        public EditModel(IRoomTypeService roomTypeService)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (await _roomTypeService.UpdateRoomTypeAsync(RoomType))
            {
                Message = "Success";
            }
            if (RoomType == null)
            {
                return NotFound();
            }


            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //db.Attach(RoomType).State = EntityState.Modified;

            //try
            //{
            //    await db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!RoomTypeExists(RoomType.Id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return RedirectToPage("./Index");
        }

        //private bool RoomTypeExists(int id)
        //{
        //    //return db.RoomTypes.Any(e => e.Id == id);
        //}
    }
}
