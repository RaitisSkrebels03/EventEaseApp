using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
