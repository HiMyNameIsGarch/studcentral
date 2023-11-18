using System.Security.Cryptography.X509Certificates;

namespace studcentral.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Nota { get; set; }
        public Subject Subject { get; set; }
    }
}
