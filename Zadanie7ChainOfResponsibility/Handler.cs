public interface Handler
{
    void SetNextHandler(Handler handler);
    void Handle(Ticket ticket);
}