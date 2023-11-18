namespace studcentral.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public Teacher Lecturer { get; set; }
        public int LecturerId { get; set; }
        public string Name { get; set; }
    }
}
