namespace MVCResume.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string? Duration { get; set; }
        public string? Title { get; set; }
        public string? InstName { get; set; }
        public List<Experience>? Experiences { get; set; } = new List<Experience>();
    }
}
