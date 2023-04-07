using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRM_Nunit_framework
{
    [TestFixture]
    [Ignore("All tese methods have been skipped")]
    public class Tests
    {

        IWebDriver driver;




        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            TestContext.Progress.WriteLine("Output for Set up method of  Nunit");
        }

        [Test]
        public void NavigateToTheURL()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            TestContext.Progress.WriteLine(driver.Title);
        }

        [Test]
        [Ignore("This Method is skipping")]
        public void ValidateTheTitle()
        {
            NavigateToTheURL();
            string expectedTitle = "OrangeHRM";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);

            TestContext.Progress.WriteLine("Output for Set up method of  Nunit");

        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(6000);
            driver.Close();
        }
    }
}