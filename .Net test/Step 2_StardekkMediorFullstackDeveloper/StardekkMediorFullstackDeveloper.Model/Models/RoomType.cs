using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace StardekkMediorFullstackDeveloper.Model.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        
        public DateTimeOffset CreationDate { get; set; }

        public string Name { get; set; }
        public int DefaultOccupancy { get; set; }
        public int MinimumOccupancy { get; set; }
        public int MaximumOccupancy { get; set; }
        public List<Amenity> Amenities { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
