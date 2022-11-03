using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest2
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;
        TimeSpan ts = TimeSpan.FromMinutes(2);


        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            this.app = AppInitializer.StartApp(platform);

        }
        /* [Test]
         public void WelcomeTextIsDisplayed()
         {
             AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to .NET Multi-platform App UI"));
             app.Screenshot("Welcomescreen.");
             Assert.IsTrue(results.Any());
         }

         [Test]
         public void clickButtonFunctionality()
         {
             app.Tap(c => c.Marked("Click me"));
             AppResult[] results = app.WaitForElement(c => c.Marked("Clicked 1 time"));
             Assert.IsTrue(results.Any());
         }

         [Test]
         public void doubleClickFunctionality()
         {
             app.DoubleTap(c => c.Marked("Click me"));
             AppResult[] results = app.WaitForElement(c => c.Marked("Clicked 2 times"));
             app.Screenshot("doubleClicked");
             Assert.IsTrue(results.Any());
         }
         */
        [Test]
        public void StartApp()

        {
            app.Repl();
        }
        [Test]
        public void leftsideMenuLink()
        {
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] results = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            app.Screenshot("Don't click");
            Assert.IsTrue(results.Any());
        }
        [Test]
        public void menuLinksClick()
        {
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] results = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            Assert.IsTrue(results.Any());
            app.Tap(c => c.Marked("Clients"));
            AppResult[] clientresults = app.WaitForElement(c => c.Marked("Master Client List"));
            Assert.IsTrue(clientresults.Any());
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] leftmenuresults = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            Assert.IsTrue(leftmenuresults.Any());
            app.Tap(c => c.Marked("Home"));
            AppResult[] homepageresults = app.WaitForElement(c => c.Marked("Hello, World!"));
            Assert.IsTrue(homepageresults.Any());

        }
        [Test]
        public void clientListAndDetails()
        {
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] results = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            Assert.IsTrue(results.Any());
            app.Tap(c => c.Marked("Clients"));
            AppResult[] clientresults = app.WaitForElement(c => c.Marked("Master Client List"));
            Assert.IsTrue(clientresults.Any());
            app.Tap(c => c.Text("Grims"));
            AppResult[] leftmenuresults = app.WaitForElement(c => c.Marked("Client List of"));
            Assert.IsTrue(leftmenuresults.Any());

        }
        [Test]
        public void clientListAndDetailsBackButton()
        {
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] results = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            Assert.IsTrue(results.Any());
            app.Tap(c => c.Marked("Clients"));
            AppResult[] clientresults = app.WaitForElement(c => c.Marked("Master Client List"));
            Assert.IsTrue(clientresults.Any());
            app.Tap(c => c.Text("Grims"));
            AppResult[] leftmenuresults = app.WaitForElement(c => c.Marked("Client List of"));
            Assert.IsTrue(leftmenuresults.Any());
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            AppResult[] Masterclientresults = app.WaitForElement(c => c.Marked("Master Client List"));
            Assert.IsTrue(Masterclientresults.Any());
        }
        [Test]
        public void AppScreensPortraitAndLandscape()
        {
            app.SetOrientationPortrait();
            System.Threading.Thread.Sleep(3000);
            app.Screenshot("Start page in portrait mode");
            app.Tap(c => c.Class("androidx.appcompat.widget.AppCompatImageButton"));
            app.SetOrientationLandscape();
            System.Threading.Thread.Sleep(3000);
            app.Screenshot("Start page in landscape mode");
            System.Threading.Thread.Sleep(3000);
            AppResult[] results = app.WaitForElement(c => c.Marked("Tabs (Don't click)"));
            Assert.IsTrue(results.Any());
            app.Back();
            System.Threading.Thread.Sleep(3000);
            app.Screenshot("Start page back");

        }
        //  [Test]
        public void PinchToZoomOutCoordinates()
        {
            System.Threading.Thread.Sleep(3000);
            app.PinchToZoomOutCoordinates(300, 200, ts);
            app.Screenshot("PinchToZoomOutCoordinates");

        }//

        [Test]
        public void volumeUpAndDown()
        {
            System.Threading.Thread.Sleep(3000);
            app.PressVolumeUp();
            app.Screenshot("PressVolumeUp");
            app.PressVolumeDown();
            app.Screenshot("PressVolumeDown");
            app.Back();
        }
        [Test]
        public void scrollDown()
        {
            System.Threading.Thread.Sleep(3000);
            app.ScrollDown();
            app.Screenshot("ScrollDown");

        }
        [Test]
        public void scrollUp()
        {
            System.Threading.Thread.Sleep(3000);
            app.ScrollDown();
            System.Threading.Thread.Sleep(3000);
            app.ScrollUp();
            app.Screenshot("ScrollUp");

        }

    }
}
