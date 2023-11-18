namespace studcentral.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public University University { get; set; }
        public int UniversityId { get; set; }
    }
}
