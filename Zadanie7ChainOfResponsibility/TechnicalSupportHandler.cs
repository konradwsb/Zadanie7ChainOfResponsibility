public class TechnicalSupportHandler : Handler
{
    private Handler nextHandler;

    public void SetNextHandler(Handler handler)
    {
        nextHandler = handler;
    }

    public void Handle(Ticket ticket)
    {
        if (ticket.Type.Equals("Technical", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Technical Support: Handling ticket - " + ticket.Description);
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(ticket);
        }
    }
}