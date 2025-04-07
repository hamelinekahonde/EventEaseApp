using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.VenueBookingSystem.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string EventName { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // Optional venue
        public int? VenueId { get; set; }
        [ForeignKey("VenueId")]
        public Venue Venue { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
