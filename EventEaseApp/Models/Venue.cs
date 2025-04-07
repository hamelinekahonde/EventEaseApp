using System.ComponentModel.DataAnnotations;

namespace EventEaseVenueBooking.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        // Navigation property
        public ICollection<Event> Events { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
