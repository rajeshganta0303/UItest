using Microsoft.Maui.Hosting;

namespace NavigationComplexData;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("ClientDetails", typeof(NavigationComplexData.Resources.Views.ClientDetailsPage));
    }
}
