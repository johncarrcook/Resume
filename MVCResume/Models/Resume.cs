namespace MVCResume.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Title { get; set; }
        public string? InstName { get; set; }
        public string? Location { get; set; }
        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
