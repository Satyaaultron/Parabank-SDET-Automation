using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver; 
    }

    private By usernameTextbox = By.Name("username"); 

    private By passwordTextbox = By.Name("password"); 

    private By loginButton = By.XPath("//input[@value='Log In']"); 

    private By errorMessage = By.ClassName("error");

    public void EnterUsername(string username)
    {
        driver.FindElement(usernameTextbox).Clear();

        driver.FindElement(usernameTextbox).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(passwordTextbox).Clear();

        driver.FindElement(passwordTextbox).SendKeys(password);
    }

    public void ClickLogin()
    {
        driver.FindElement(loginButton).Click();
    }

    public string GetErrorMessage()
    {
        return driver.FindElement(errorMessage).Text;
    }
}