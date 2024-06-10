using AnimalService.Entities;
using System.ComponentModel.DataAnnotations;

namespace AnimalService.DTOs
{
    public class CreateAnimalDto
    {
        [Required]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public string Type { get; set; } = default!;
        [Required]
        public string Breed { get; set; } = default!;
        [Required]
        public string Sex { get; set; } = default!;
        [Required]
        public int Weight { get; set; }
        [Required]
        public string Color { get; set; } = default!;
        [Required]
        public string Description { get; set; } = default!;
        [Required]
        public string CoverImageUrl { get; set; } = default!;
        [Required]
        public Status Status { get; set; }
    }
}
