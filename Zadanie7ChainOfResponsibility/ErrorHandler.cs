public class ErrorHandler : Handler
{
    private Handler nextHandler;

    public void SetNextHandler(Handler handler)
    {
        nextHandler = handler;
    }

    public void Handle(Ticket ticket)
    {
        Console.WriteLine("Error: Invalid ticket type - " + ticket.Type);
    }
}