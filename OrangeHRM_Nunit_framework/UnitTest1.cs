using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHRM_Nunit_framework.BaseClass;

namespace OrangeHRM_Nunit_framework
{
    [TestFixture]

    public class Tests : BaseTest
    {

        [Test]
        public void NavigateToTheURL()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Click();
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/button[1]")).Click();

        }

        [Test]
        public void AddAdmin()
        {
            NavigateToTheURL();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/aside[1]/nav[1]/div[2]/ul[1]/li[1]/a[1]")).Click();


        }
    }
}