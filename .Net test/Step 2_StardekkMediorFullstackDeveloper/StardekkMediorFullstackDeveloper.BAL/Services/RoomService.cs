using AutoMapper;

using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using StardekkMediorFullstackDeveloper.Repositories.Interface;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;

        public RoomService(IMapper mapper, IRoomRepository roomRepository, IRoomTypeRepository roomTypeRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<List<RoomViewModel>> GetAllRooms()
        {
            List<Room> models = await _roomRepository.GetAll();
            return _mapper.Map<List<Room>, List<RoomViewModel>>(models);

        }

        public async Task<RoomViewModel> GetRoomByIdAsync(int id)
        {
            RoomViewModel viewModel = new RoomViewModel();
            if (id > 0)
            {
                Room model = await _roomRepository.GetByIdAsync(id);
                viewModel = _mapper.Map<Model.ViewModels.RoomViewModel>(model);
            }
            viewModel.RoomTypes = _mapper.Map<List<RoomType>, List<RoomTypeViewModel>>(await _roomTypeRepository.GetAll());
            return viewModel;
        }

        public async Task<bool> AddRoomAsync(RoomViewModel room)
        {
            Room model = _mapper.Map<Room>(room);
            return await _roomRepository.AddAsync(model);
        }

        public async Task<bool> UpdateRoomAsync(RoomViewModel room)
        {
            Room model = _mapper.Map<Room>(room);
            return await _roomRepository.UpdateAsync(model);
        }
        public async Task<bool> DeleteRoomAsync(int id)
        {
            return await _roomRepository.DeleteByIdAsync(id);
        }
    }
}
