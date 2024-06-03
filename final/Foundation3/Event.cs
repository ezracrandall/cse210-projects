public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title,string description,DateTime date,DateTime time,Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Title => _title;
    public string Description => _description;
    public DateTime Date => _date;
    public DateTime Time => _time;
    public Address Address => _address;

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToShortTimeString()}\nAddress: {Address}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name} - Title: {Title}, Date: {Date.ToShortDateString()}";
    }
}