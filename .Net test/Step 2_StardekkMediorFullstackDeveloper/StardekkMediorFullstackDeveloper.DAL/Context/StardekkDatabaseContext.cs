using Microsoft.EntityFrameworkCore;

using StardekkMediorFullstackDeveloper.Model.Models;

namespace StardekkMediorFullstackDeveloper.DAL
{
    public class StardekkDatabaseContext : DbContext
    {
        public StardekkDatabaseContext()
        {

        }
        public StardekkDatabaseContext(DbContextOptions<StardekkDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=StardekkMediorFullstackDeveloper.db");
    }
}
