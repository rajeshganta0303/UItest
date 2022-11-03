using NavigationComplexData.Resources.Models;

namespace NavigationComplexData.Resources.Views;

public partial class ClientsPage : ContentPage
{
    public MasterClientsList MasterClientsList { get; set; }

    public ClientsPage()
	{
		InitializeComponent();

        MasterClientsList = new MasterClientsList();
        this.BindingContext = this;
    }

    async void lstClients_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        // Get the selected Master Client from the ListItem
        var client = (MasterClient)lstClients.SelectedItem;
        // Create a Navigation Parameter using the Dictionary
        var navigationParameter = new Dictionary<string, object>
        {
            { "SelectedClient",  client }
        };

        // Navigate to the Employees Route with the Navigation Parameter
        await Shell.Current.GoToAsync($"ClientDetails", navigationParameter);
    }
}