using System.ComponentModel.DataAnnotations;

namespace OneFB.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string RedirectURL { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string ImageURL { get; set; }


    }
}
