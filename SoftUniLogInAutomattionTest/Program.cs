using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SoftUniLogInAutomattionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "mitko.stamatov";
            string Password = "P10vdiv1319";

            //Chrome Options
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            options.AddArguments("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://softuni.bg");

            driver.FindElement(By.LinkText("Вход")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));

            IWebElement loginButton = wait.Until<IWebElement>
                ((w) => { return w.FindElement(By.CssSelector(".btn.btn-primary.btn-lg.btn-long.top-buffer.col-md-12")); });

            driver.FindElement(By.Id("username")).SendKeys(Username);
            driver.FindElement(By.Id("password")).SendKeys(Password);

            loginButton.Click();

            //wait
            Thread.Sleep(5000);

            //close
            driver.Close();

        }
    }
}
