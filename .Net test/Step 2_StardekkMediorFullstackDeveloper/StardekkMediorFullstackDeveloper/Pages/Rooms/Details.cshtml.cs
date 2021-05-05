﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.DAL;
using StardekkMediorFullstackDeveloper.Model.ViewModels;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.Pages.Rooms
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public RoomViewModel Room { get; set; }

        [BindProperty]
        public string Message { get; set; }

        private readonly IRoomService _roomService;

        public DetailsModel(IRoomService roomService)
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
    }
}
