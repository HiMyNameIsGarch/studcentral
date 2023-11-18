namespace studcentral.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty FacultyId { get; set; }
        public string UniversityEmail { get; set; }
        public string ContactInfo { get; set; }
    }
}
