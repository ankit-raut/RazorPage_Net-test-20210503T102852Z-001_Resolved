using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Interface
{
    public interface IRoomTypeService
    {
        Task<List<RoomTypeViewModel>> GetAllRoomTypes();
        Task<RoomTypeViewModel> GetRoomTypeByIdAsync(int id);
        Task<bool> AddRoomTypeAsync(RoomTypeViewModel newRoomType);
        Task<bool> UpdateRoomTypeAsync(RoomTypeViewModel newRoomType);
        Task<bool> DeleteRoomTypeAsync(int id);
    }
}
