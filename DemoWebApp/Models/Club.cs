using DemoWebApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebApp.Models
{
    public class Club
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }
        public ClubCategory? ClubCategory { get; set; }
        [ForeignKey("AppUser")]
        public Guid AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
