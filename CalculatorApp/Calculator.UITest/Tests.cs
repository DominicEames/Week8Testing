using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Calculator.UITest
{
    [TestFixture(Platform.Android)]
    // [TestFixture(Platform.iOS)]
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
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }
        [Test]
        public void TestAdd()
        {
            app.EnterText("value1", "10");
            app.EnterText("value1", "5");
            app.Tap("btnAdd");
            var AddResult = app.Query("value3").First(result => result.Text == "15");
            Assert.IsTrue(AddResult != null, "The Add testcase has failed, please check");
        }
    }
}
