using StardekkMediorFullstackDeveloper.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StardekkMediorFullstackDeveloper.Model.ViewModels
{
    public class RoomTypeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Creation date.")]
        [DataType(DataType.Date)]
        [Display(Name = "Creation Date")]
        public DateTimeOffset CreationDate { get; set; }
        [Required,StringLength(maximumLength:50, MinimumLength =3,ErrorMessage ="{0} must be between {1} to {2}")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default Occupancy")]
        public int DefaultOccupancy { get; set; }
        [Required]
        [Display(Name = "Minimum Occupancy")]
        public int MinimumOccupancy { get; set; }
        [Required]
        [Display(Name = "Maximum Occupancy")]
        public int MaximumOccupancy { get; set; }
        public List<AmenityViewModel> Amenities { get; set; }
        public List<RoomViewModel> Rooms { get; set; }
    }
}
