public class Ticket
{
    public string Type { get; }
    public string Description { get; }

    public Ticket(string type, string description)
    {
        Type = type;
        Description = description;
    }
}