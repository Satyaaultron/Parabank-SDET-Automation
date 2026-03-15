# Parabank Login Automation

This project automates the login functionality of the Parabank application.

Application URL
https://parabank.parasoft.com/

Tech Stack
- C#
- .NET 6
- Selenium WebDriver
- NUnit
- Page Object Model

Project Structure

Base
  BaseTest.cs

Pages
  LoginPage.cs

Tests
  LoginTests.cs

Utilities
  WaitHelper.cs

Setup Instructions

1. Install Visual Studio
2. Install .NET 6 or later
3. Clone repository

git clone <repository-url>

4. Install NuGet packages

Selenium.WebDriver
Selenium.WebDriver.ChromeDriver
NUnit
NUnit3TestAdapter

Running Tests

Open Test Explorer in Visual Studio

Test → Test Explorer

Click Run All Tests

Automation Design

- Page Object Model
- Explicit Waits
- Independent Tests
- Clean and maintainable framework