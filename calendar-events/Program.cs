namespace calendar_events;

public class Program
{    
    public static void Main()
    {
        Dialogs.ShowInitialMessage();
        EventList myEventList = new EventList();
        myEventList.Add(new Event("Evento sem descrição", "2015-06-05"));
        myEventList.Add(new Event("Evento completo 1", "2015-08-05", "esse vai ser bom"));
        myEventList.Add(new Event("Evento completo 2", "2015-07-05", "esse vai ser bom"));
        myEventList.Add(new Event("Evento completo 3", "2015-05-05", "esse vai ser bom"));

        bool isDeteailed = Dialogs.ShowDetails();
        string format = isDeteailed ? "detailed" : "normal";

        myEventList.Print(format);
    }
}
