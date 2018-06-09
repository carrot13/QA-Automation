using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SoftUniLogInAutomattionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "mitko.stamatov";
            string Password = "P10vdiv1319";
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            options.AddArguments("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://softuni.bg");
            driver.Navigate().Refresh();
            driver.FindElement(By.LinkText("Вход")).Click();
            driver.FindElement(By.Id("username")).SendKeys(Username);
            driver.FindElement(By.Id("password")).SendKeys(Password);
            driver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg.btn-long.top-buffer.col-md-12")).Click();
        }
    }
}
