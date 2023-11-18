namespace studcentral.Models
{
    public class MedicalCentre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LocationLocation Location { get; set; }
        public int LocationId { get; set; }
        public string Schedule {  get; set; }

    }
}
