public class GeneralSupportHandler : Handler
{
    private Handler nextHandler;

    public void SetNextHandler(Handler handler)
    {
        nextHandler = handler;
    }

    public void Handle(Ticket ticket)
    {
        if (ticket.Type.Equals("General", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("General Support: Handling ticket - " + ticket.Description);
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(ticket);
        }
    }
}