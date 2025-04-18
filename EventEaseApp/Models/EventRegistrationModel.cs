using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventRegistrationModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select an event.")]
        public int? EventId { get; set; }
    }
}
