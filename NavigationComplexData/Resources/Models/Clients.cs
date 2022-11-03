using System.Collections.ObjectModel;

namespace NavigationComplexData.Resources.Models;

public class MasterClient
{
    public int ClientId { get; set; }
    public string ClientName { get; set; }
}
public class MasterClientsList : ObservableCollection<MasterClient>
{
    public MasterClientsList()
    {
        Add(new MasterClient() { ClientId = 10, ClientName = "Grims" });
        Add(new MasterClient() { ClientId = 20, ClientName = "Doe" });
        Add(new MasterClient() { ClientId = 30, ClientName = "Morgan" });
        Add(new MasterClient() { ClientId = 40, ClientName = "Potter" });
        Add(new MasterClient() { ClientId = 50, ClientName = "Granger" });
    }
}

public class Clients
{
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string Status { get; set; }
    public string Email { get; set; }
}
public class ClientLists : ObservableCollection<Clients>
{
    public ClientLists()
    {
        Add(new Clients() { ClientId = 10, ClientName = "Rick Grims", Status = "Active", Email = "rick@grims.com" });
        Add(new Clients() { ClientId = 10, ClientName = "Mike Grims", Status = "Inactive", Email = "mike@grims.com" });
        Add(new Clients() { ClientId = 20, ClientName = "John Doe", Status = "Active", Email = "john@doe.com" });
        Add(new Clients() { ClientId = 20, ClientName = "Micheal Doe", Status = "Active", Email = "micheal@doe.com" });
        Add(new Clients() { ClientId = 20, ClientName = "Mark Doe", Status = "Past Due", Email = "mark@doe.com" });
        Add(new Clients() { ClientId = 30, ClientName = "Henry Morgan", Status = "Pending", Email = "henry@morgan.com" });
        Add(new Clients() { ClientId = 30, ClientName = "Abraham Morgan", Status = "Active", Email = "abraham@morgan.com" });
        Add(new Clients() { ClientId = 30, ClientName = "Abigail Morgan", Status = "Inactive", Email = "abigail@morgan.com" });
        Add(new Clients() { ClientId = 40, ClientName = "Harry Potter", Status = "Active", Email = "harry@potter.com" });
        Add(new Clients() { ClientId = 40, ClientName = "James Potter", Status = "Active", Email = "james@potter.com" });
        Add(new Clients() { ClientId = 40, ClientName = "Lily Potter", Status = "Suspend", Email = "lily@potter.com" });
        Add(new Clients() { ClientId = 50, ClientName = "Hermonie Granger", Status = "Active", Email = "hermonie@granger.com" });
    }
}