using Microsoft.AspNetCore.Mvc.RazorPages;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.Rooms
{
    public class IndexModel : PageModel
    {
        private readonly IRoomService _roomService;
        public IList<RoomViewModel> Room { get;set; }

        public IndexModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task OnGetAsync()
        {
            this.Room = await _roomService.GetAllRooms();
        }
    }
}
