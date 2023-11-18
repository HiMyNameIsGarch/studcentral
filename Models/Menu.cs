namespace studcentral.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public ICollection<Item> Items { get; set; }
     
    }
}
