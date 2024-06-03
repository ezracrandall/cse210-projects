public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title,string description,DateTime date,DateTime time,Address address,string speaker,int capacity)
        : base(title,description,date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string Speaker => _speaker;
    public int Capacity => _capacity;

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}