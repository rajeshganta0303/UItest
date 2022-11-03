using NavigationComplexData.Resources.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace NavigationComplexData.Resources.Views;

public partial class ClientDetailsPage : ContentPage, IQueryAttributable
{
    public ObservableCollection<Clients> ClientsList { get; set; }
    public string MasterClientName { get; set; }

    public ClientDetailsPage()
	{
		InitializeComponent();

        ClientsList = new ClientLists();
        this.BindingContext = this;
        OnPropertyChanged();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var masterclient = query["SelectedClient"] as MasterClient;
        MasterClientName = masterclient.ClientName;

        Clients[] filteredData = ClientsList.Where(client => client.ClientId == masterclient.ClientId).ToArray();
        ClientsList.Clear();
        foreach (var client in filteredData)
        {
            ClientsList.Add(client);
            // customers.Add(client);
        }

        OnPropertyChanged();
    }

    // Data to be written to the file system, and read back later
    public List<Clients> customers;
    public string fileName = "ClientList";

    // Serialize and save
    public void SaveData()
    {
        var serializedData = JsonSerializer.Serialize(customers);
        File.WriteAllText(fileName, serializedData);
    }

    // Read and deserialize
    public void ReadData()
    {
        var rawData = File.ReadAllText(fileName);
        customers = JsonSerializer.Deserialize<List<Clients>>(rawData);
    }
}