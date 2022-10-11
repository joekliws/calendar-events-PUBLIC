using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{
    public string? Title {get; set; }
    public DateTime EventDate {get; set; }
    public string? Description {get; set; }
        

    public Event(string title, string date, string? description = null)
    {
        Title = title;
        EventDate = DateTimeUtils.validateDate(date);
        Description = description;
    }

    public void DelayDate(int days)
    {
        if (days <= 0) throw new ArgumentException("Day cannot be negative");
        EventDate = EventDate.AddDays(days);

        
    }

    public string PrintEvent(string format)
    {
        bool isDetailed = format.Equals("detailed", StringComparison.InvariantCultureIgnoreCase);
        bool isValid = format.Equals("normal", StringComparison.InvariantCultureIgnoreCase)
        || isDetailed;
        
        if (!isValid) throw new ArgumentException("inválid format");

        return isDetailed 
        ? $"Evento = {Title}\nDate = {EventDate:dd/MM/yyyy}\nDescription = {Description}\n" 
        : $"Evento = {Title}\nDate = {EventDate:dd/MM/yyyy}\n";
    }

}
