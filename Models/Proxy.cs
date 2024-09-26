public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if(_realSubject == null)
        {
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy: Pre-processing before forwarding the request.");
        _realSubject.Request();
        Console.WriteLine("Proxy: Post-processing after forwarding the request.");
    }
}