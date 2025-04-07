using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEaseApp.Models;

namespace EventEaseVenueBooking.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [StringLength(100)]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        // Optional foreign key (event can exist without venue assigned)
        public int? VenueId { get; set; }

        [ForeignKey("VenueId")]
        public Venue Venue { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
