using Microsoft.EntityFrameworkCore;

using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.Repositories.Repository;
using StardekkMediorFullstackDeveloper.Repositories.Interface;
using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.DAL.Repositories.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        public AmenityRepository(StardekkDatabaseContext stardekkDatabaseContext) : base(stardekkDatabaseContext)
        {
        }
    }
}
