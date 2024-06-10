using System.ComponentModel.DataAnnotations;

namespace AnimalService.Entities
{
    public class Animal
    {
        [Key]
        public Guid Id { get; set; }
        public int PublicId { get; set; }
        public int Age { get; set; }
        public string Name { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Breed { get; set; } = default!;
        public string Sex { get; set; } = default!;
        public int Weight { get; set; } = default!;
        public string Color { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string CoverImageUrl { get; set; } = default!;
        public Status Status { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
