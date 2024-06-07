public class BillingSupportHandler : Handler
{
    private Handler nextHandler;

    public void SetNextHandler(Handler handler)
    {
        nextHandler = handler;
    }

    public void Handle(Ticket ticket)
    {
        if (ticket.Type.Equals("Billing", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Billing Support: Handling ticket - " + ticket.Description);
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(ticket);
        }
    }
}