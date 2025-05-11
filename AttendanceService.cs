public class AttendanceService
{
    private readonly Dictionary<int, List<string>> _eventAttendances = new();

    public void AddAttendance(int eventId, string userName)
    {
        if (!_eventAttendances.ContainsKey(eventId))
        {
            _eventAttendances[eventId] = new List<string>();
        }

        _eventAttendances[eventId].Add(userName);
    }

    public List<string> GetAttendees(int eventId)
    {
        return _eventAttendances.ContainsKey(eventId) ? _eventAttendances[eventId] : new List<string>();
    }
}
