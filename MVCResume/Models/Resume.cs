using System.ComponentModel.DataAnnotations;

namespace MVCResume.Models
{
    public class Resume
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Activity> Activities { get; set; } = new List<Activity>();
    }
}
