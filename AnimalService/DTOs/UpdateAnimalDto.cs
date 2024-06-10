namespace AnimalService.DTOs
{
    public class UpdateAnimalDto
    {
        public int Age { get; set; }
        public string Name { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string Breed { get; set; } = default!;
        public string Sex { get; set; } = default!;
        public int Weight { get; set; }
        public string Color { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string CoverImageUrl { get; set; } = default!;
        public string Status { get; set; } = default!;
    }
}
