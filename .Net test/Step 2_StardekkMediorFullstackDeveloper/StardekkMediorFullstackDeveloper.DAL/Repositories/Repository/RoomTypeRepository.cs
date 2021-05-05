using Microsoft.EntityFrameworkCore;

using StardekkMediorFullstackDeveloper.Model.Models;
using StardekkMediorFullstackDeveloper.Model.Repositories.Repository;
using StardekkMediorFullstackDeveloper.Repositories.Interface;

using System.Threading.Tasks;

namespace StardekkMediorFullstackDeveloper.DAL.Repositories.Repository
{
    public class RoomTypeRepository : Repository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(StardekkDatabaseContext stardekkDatabaseContext) : base(stardekkDatabaseContext)
        {
        }
    }
}
