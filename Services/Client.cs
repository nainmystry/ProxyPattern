
public class Client
{
    private ISubject _subject;

    public Client(ISubject subject)
    {
        _subject = subject;
    }

    public void MakeRequest()
    {
        _subject.Request();
    }
}