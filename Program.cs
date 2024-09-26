// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


ISubject subject = new Proxy();
Client client = new Client(subject);
client.MakeRequest();