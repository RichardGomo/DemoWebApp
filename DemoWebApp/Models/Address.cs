using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } =string.Empty;
        public string Province { get; set; } = string.Empty;
    }
}
