namespace calendar_events;
public interface IEvent
{       
    void DelayDate(int days);
    string PrintEvent(string format);
}
