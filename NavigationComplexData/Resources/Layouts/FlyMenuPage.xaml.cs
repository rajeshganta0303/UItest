namespace NavigationComplexData.Resources.Layout;

public partial class FlyMenuPage : ContentPage
{
	public FlyMenuPage()
	{
		InitializeComponent();
	}

}

public class FlyoutPageItem
{
    public string Title { get; set; }
    public string IconSource { get; set; }
    public Type TargetType { get; set; }
}