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

        //https://nftb.saturdaymp.com/today-i-learned-how-to-create-xamarin-ios-and-android-unit-tests/
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
            app.Tap(x => x.Marked("Name:"));
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
            app.Tap(x => x.Text("Name:"));
            app.Screenshot("Before calling ClearText");
            app.EnterText("The test worked!");
            app.Screenshot("Text entered");
            app.ClearText();
            app.Screenshot("Text cleared & replaced");
            app.Back();
        }

        [Test]
        public void SaveTaskExample()
        {
            app.Screenshot("First screen - Save task test.");
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Name:"));
            app.Screenshot("Before calling SaveText");
            app.EnterText("New Task Test");
            app.Screenshot("Text entered");
            app.Tap(x => x.Marked("Save"));
            app.Screenshot("Saved");
            app.Back();
        }

        [Test]
        public void ListTaskExample()
        {
            app.Screenshot("First screen - list tasks test.");
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Name:"));
            app.Screenshot("Before calling SaveText");
            app.EnterText("New Task Test");
            app.Screenshot("Text entered");
            app.Tap(x => x.Marked("Save"));
            app.Screenshot("Saved");
            //add second task
            app.Tap(x => x.Marked("Add Task"));
            app.Tap(x => x.Text("Name:"));
            app.Screenshot("Before calling SaveText");
            app.EnterText("New Task Test 2");
            app.Screenshot("Text entered");
            app.Tap(x => x.Marked("Save"));
            app.Screenshot("Saved");
            app.Back();
        }

        //testing
    }
}

