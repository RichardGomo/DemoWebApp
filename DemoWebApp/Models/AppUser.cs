using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Models
{
    public class AppUser 
    {
        [Key]
        public Guid? Pace { get; set; }
        public int? Milage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Race { get; set; }

        // One thing that pple dont realise is that when you are building models
        // you are actually using abstraction
    }
}
