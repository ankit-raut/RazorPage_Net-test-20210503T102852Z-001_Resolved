using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StardekkMediorFullstackDeveloper.Model.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter the Creation date.")]
        [DataType(DataType.Date)]
        [Display(Name = "Creation Date")]
        public DateTimeOffset CreationDate { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }
        [Display(Name = "Room Type")]
        public RoomTypeViewModel RoomType { get; set; }
        public int RoomTypeId { get; set; }
        public List<RoomTypeViewModel> RoomTypes { get; set; }


    }
}
