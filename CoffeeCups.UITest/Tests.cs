using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CoffeeCups.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        //public void AppLaunches()
        //{
        //    app.Screenshot("First screen.");
        //}

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Text("Add Coffee"));
            app.Screenshot("Tapped on view with class: AppCompatButton");
            System.Threading.Thread.Sleep(5000);
            app.SwipeLeftToRight();
            System.Threading.Thread.Sleep(2000);
            app.Tap(x => x.Text("Add Coffee"));
            System.Threading.Thread.Sleep(5000);
            app.Screenshot("Tapped on view with class: AppCompatButton");
            app.SwipeRightToLeft();
            System.Threading.Thread.Sleep(2000);
            app.ScrollDown();
            app.Screenshot("Swiped up");
        }
    }
}

