using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace NavigationComplexData;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
            protected override void OnStart()
            {
               AppCenter.Start("android= 648a3101-ad7b-4799-a9d4-7c52c08a889e;" +
                  "uwp=1d432e51-b87c-4fd7-ae67-9230f8ec3d71;" +
                  "ios=d51dc0d3-54da-469a-af42-f2f063a48ca4;" +
                  "macos=10ae48fe-ffb6-44d3-9922-7f76efd10327;",
                  typeof(Analytics), typeof(Crashes));

            }

}
