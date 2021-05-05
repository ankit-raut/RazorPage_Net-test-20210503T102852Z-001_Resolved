using AutoMapper;
using StardekkMediorFullstackDeveloper.BAL.Interface;
using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using StardekkMediorFullstackDeveloper.Repositories.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Services
{
    public class AmenityService : IAmenityService
    {
        private readonly IAmenityRepository _amenityRepository;
        private readonly IMapper _mapper;

        public AmenityService(IMapper mapper, IAmenityRepository amenityRepository)
        {
            _mapper = mapper;
            _amenityRepository = amenityRepository;
        }

        public async Task<List<AmenityViewModel>> GetAllAmenities()
        {
            List<Amenity> models = await _amenityRepository.GetAll();
            return _mapper.Map<List<Amenity>, List<AmenityViewModel>>(models);
        }

        public async Task<AmenityViewModel> GetAmenityByIdAsync(int id)
        {
            Amenity model = await _amenityRepository.GetByIdAsync(id);
            return _mapper.Map<AmenityViewModel>(model);
        }

        public async Task<bool> AddAmenityAsync(AmenityViewModel newAmenity)
        {
            Amenity model = _mapper.Map<Amenity>(newAmenity);
            return await _amenityRepository.AddAsync(model);
        }

        public async Task<bool> UpdateAmenityAsync(AmenityViewModel newAmenity)
        {
            Amenity model = _mapper.Map<Amenity>(newAmenity);
            return await _amenityRepository.UpdateAsync(model);
        }

        public async Task<bool> DeleteAmenityAsync(int id)
        {
            return await _amenityRepository.DeleteByIdAsync(id);
        }
    }
}
