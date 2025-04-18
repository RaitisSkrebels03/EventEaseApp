using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private List<AttendeeModel> attendees = new();

        public void Register(string name)
        {
            attendees.Add(new AttendeeModel { Name = name });
        }

        public List<AttendeeModel> GetAll() => attendees;

        public void MarkAttended(string name)
        {
            var person = attendees.FirstOrDefault(a => a.Name == name);
            if (person != null)
                person.Attended = true;
        }
    }
}
