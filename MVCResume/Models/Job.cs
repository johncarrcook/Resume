namespace MVCResume.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? Title { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyLocation { get; set; }
        public List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
