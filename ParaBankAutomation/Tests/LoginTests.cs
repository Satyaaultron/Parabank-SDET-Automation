using NUnit.Framework;
using OpenQA.Selenium;

public class LoginTests : BaseTest
{

    [Test] 
    public void ValidLoginTest()
    {
        LoginPage loginPage = new LoginPage(driver); 

        loginPage.EnterUsername("satyambqa");

        loginPage.EnterPassword("KenCRM#4590!");

        loginPage.ClickLogin();

        string pageTitle = driver.Title;

        Assert.IsTrue(pageTitle.Contains("ParaBank"));
    }

    [Test]
    public void InvalidLoginTest()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.EnterUsername("wronguser");

        loginPage.EnterPassword("wrongpass");

        loginPage.ClickLogin();

        string error = loginPage.GetErrorMessage();

        Assert.IsTrue(error.Contains("The username and password could not be verified."));
    }

    [Test]
    public void BlankUsernameTest()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.EnterUsername("");

        loginPage.EnterPassword("demo");

        loginPage.ClickLogin();

        string error = loginPage.GetErrorMessage();

        Assert.IsTrue(error.Length > 0);

        Assert.IsTrue(error.Contains("Please enter a username and password."));
    }

    [Test]
    public void BlankPasswordTest()
    {
        LoginPage loginPage = new LoginPage(driver);

        loginPage.EnterUsername("john");

        loginPage.EnterPassword("");

        loginPage.ClickLogin();

        string error = loginPage.GetErrorMessage();

        Assert.IsTrue(error.Length > 0);

        Assert.IsTrue(error.Contains("Please enter a username and password."));
    }
}