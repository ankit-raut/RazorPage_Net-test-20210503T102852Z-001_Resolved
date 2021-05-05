using AutoMapper;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using StardekkMediorFullstackDeveloper.Repositories.Interface;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;

        public RoomTypeService(IMapper mapper, IRoomTypeRepository roomTypeRepository)
        {
            _mapper = mapper;
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<List<RoomTypeViewModel>> GetAllRoomTypes()
        {
            List<RoomType> models = await _roomTypeRepository.GetAll();
            return _mapper.Map<List<RoomType>, List<RoomTypeViewModel>>(models);

        }

        public async Task<RoomTypeViewModel> GetRoomTypeByIdAsync(int id)
        {
            RoomType model = await _roomTypeRepository.GetByIdAsync(id);
            return _mapper.Map<RoomTypeViewModel>(model);
        }

        public async Task<bool> AddRoomTypeAsync(RoomTypeViewModel newRoomType)
        {
            RoomType model = _mapper.Map<RoomType>(newRoomType);
            return await _roomTypeRepository.AddAsync(model);
        }

        public async Task<bool> UpdateRoomTypeAsync(RoomTypeViewModel newRoomType)
        {
            RoomType model = _mapper.Map<RoomType>(newRoomType);
            return await _roomTypeRepository.UpdateAsync(model);
        }
        public async Task<bool> DeleteRoomTypeAsync(int id)
        {
            return await _roomTypeRepository.DeleteByIdAsync(id);
        }
    }
}
