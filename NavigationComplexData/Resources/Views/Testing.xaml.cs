namespace NavigationComplexData.Resources.Views;

public partial class TestingPage : ContentPage
{
	public TestingPage()
	{
		InitializeComponent();
	}

	public void OnClicked(object sender, EventArgs e)
	{
		var parameterValueToPassBack = "Hello";
        Shell.Current.GoToAsync($"//ClientsPage?parameterToPassBack={parameterValueToPassBack}");
    }
}

