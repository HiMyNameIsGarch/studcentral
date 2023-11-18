namespace studcentral.Models
{
    public class UniNotes
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
