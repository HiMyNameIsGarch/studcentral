namespace studcentral.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UniversityEmail { get; set; }
        public string ContactInfo { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }


    }
}
