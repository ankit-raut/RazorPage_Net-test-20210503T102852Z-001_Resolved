using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.BAL.Interface
{
    public interface IAmenityService
    {
        Task<List<AmenityViewModel>> GetAllAmenities();
        Task<AmenityViewModel> GetAmenityByIdAsync(int id);
        Task<bool> AddAmenityAsync(AmenityViewModel newAmenity);
        Task<bool> UpdateAmenityAsync(AmenityViewModel newAmenity);
        Task<bool> DeleteAmenityAsync(int id);
    }

}
