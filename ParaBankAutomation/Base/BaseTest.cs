using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome; 
using NUnit.Framework;

public class BaseTest
{
    protected IWebDriver driver; 

    [SetUp] 
    public void Setup()
    {
        driver = new ChromeDriver();

        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}