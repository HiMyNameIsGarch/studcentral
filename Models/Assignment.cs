namespace studcentral.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string DescriptionPdfLink { get; set; }
        public string SolutionPdfLink { get; set; }
        public Grade Grade { get; set; }
        public int GradeId { get; set; }

    }
}
