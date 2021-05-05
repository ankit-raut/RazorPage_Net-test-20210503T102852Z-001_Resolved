using System.ComponentModel.DataAnnotations;

namespace StardekkMediorFullstackDeveloper.Model.ViewModels
{
    public class AmenityViewModel
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
