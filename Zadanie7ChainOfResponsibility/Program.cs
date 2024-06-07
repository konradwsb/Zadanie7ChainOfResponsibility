
public class Program
{
    public static void Main(string[] args)
    {
        Handler techSupport = new TechnicalSupportHandler();
        Handler billingSupport = new BillingSupportHandler();
        Handler generalSupport = new GeneralSupportHandler();
        Handler errorSupport = new ErrorHandler();

        techSupport.SetNextHandler(billingSupport);
        billingSupport.SetNextHandler(generalSupport);
        generalSupport.SetNextHandler(errorSupport);

        while (true)
        {
            Console.WriteLine("Select ticket type (Technical/Billing/General/End):");
            string type = Console.ReadLine().Trim();

            if (type.Equals("End", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.WriteLine("Enter ticket description:");
            string description = Console.ReadLine().Trim();

            Ticket ticket = new Ticket(type, description);
            techSupport.Handle(ticket);
        }
    }
}



