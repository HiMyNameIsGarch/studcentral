using System.Text.RegularExpressions;

namespace studcentral.Models
{
    public class Class
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public string ClassType { get; set; }
        public bool Mandatory { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public DateTime Time { get; set; }

    }
}
