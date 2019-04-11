using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TaskyUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
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

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        https://nftb.saturdaymp.com/today-i-learned-how-to-create-xamarin-ios-and-android-unit-tests/
        [Test]
        public void SmokeTest()
        {
            Assert.That(true);
        }

        [Test]
        public void EnterTextExample()
        {
            app.Screenshot("First screen - Enter text test.");
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Item name"));

            app.Screenshot("Before calling EnterText");
            app.EnterText("The test worked!");
            app.Screenshot("Text entered");
            app.Back();
        }

        // https://github.com/King-of-Spades/AppCenter-Test-Samples/blob/master/Xamarin.UITest/UITestDemo/UITestDemo.UITest
        [Test]
        public void ClearTextExample()
        {
            app.Screenshot("First screen - Clear text test.");
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Name"));

            app.Screenshot("Before calling ClearText");
            app.ClearText();
            app.EnterText("The test worked!");
            app.Screenshot("Text cleared & replaced");
            app.Back();
        }
    }
}

