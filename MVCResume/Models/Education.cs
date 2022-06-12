namespace MVCResume.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string? GradDate { get; set; }
        public string? Degree { get; set; }
        public string? InstName { get; set; }
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();
    }
}
