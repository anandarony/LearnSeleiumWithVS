// See https://aka.ms/new-console-template for more information

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World! Test");

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://www.anandarony.com");

        // Maximize the browser window
        driver.Manage().Window.Maximize();

        // Find an element using its ID and perform an action
        IWebElement element = driver.FindElement(By.CssSelector("#menu-item-20 > a:nth-child(1)"));
        element.SendKeys("Hello, Selenium!");

        // Click a button
        IWebElement button = driver.FindElement(By.CssSelector("#menu-item-20 > a:nth-child(1)"));
        button.Click();

        // Wait for a few seconds to see the result
        System.Threading.Thread.Sleep(5000);

        // Close the browser
        driver.Quit();

    }

}