using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Interface
{
    public interface IRoomService
    {
        Task<List<RoomViewModel>> GetAllRooms();
        Task<RoomViewModel> GetRoomByIdAsync(int id);
        Task<bool> AddRoomAsync(RoomViewModel newRoom);
        Task<bool> UpdateRoomAsync(RoomViewModel newRoom);
        Task<bool> DeleteRoomAsync(int id);

    }
}
