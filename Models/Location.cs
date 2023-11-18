namespace studcentral.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        public LocationLocation Coordinates { get; set; }
    }
}
