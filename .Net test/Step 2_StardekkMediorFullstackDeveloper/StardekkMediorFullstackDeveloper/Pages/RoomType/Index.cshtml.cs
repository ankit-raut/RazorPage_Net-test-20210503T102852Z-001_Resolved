using Microsoft.AspNetCore.Mvc.RazorPages;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.RoomType
{
    public class IndexModel : PageModel
    {
        private readonly IRoomTypeService _roomTypeService;
        public IList<RoomTypeViewModel> RoomType { get; set; }

        public IndexModel(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        public async Task OnGetAsync()
        {
            this.RoomType = await _roomTypeService.GetAllRoomTypes();
        }

        ////private readonly StardekkMediorFullstackDeveloper.Models.StardekkDatabaseContext _context;

        ////public IndexModel(StardekkMediorFullstackDeveloper.Models.StardekkDatabaseContext context)
        ////{
        ////    _context = context;
        ////}

        //private readonly IRoomTypeService _roomTypeService;

        //public IndexModel(IRoomTypeService roomTypeService)
        //{
        //    _roomTypeService = roomTypeService;
        //}

        //public IList<Model.Models.RoomType> RoomType { get; set; }


        //public async Task OnGetAsync()
        //{
        //    //this.RoomType = await _roomTypeService.GetAllRoomTypes();
        //}
    }
}
