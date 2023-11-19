using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.Design;

namespace studcentral.Models
{
    public class Cafeteria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public LocationLocation Location { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public string Schedule {  get; set; }
    }
}