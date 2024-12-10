using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppETA25.Automation.Session2;

public class WebTableTests
{
    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";

    public const string FirstName = "Radu";
    public const string LastName = "Fifiita";
    public const string Email = "rf-test@email.com";
    public const string Age = "32";
    public const string Salary = "50000";
    public const string Department = "Software Dev";

    [SetUp]
    public void Setup()
    {
        // Initializare driver Chrome & pornire instanta browser
        Driver = new ChromeDriver();

        // Navigam la pagina de HOME: https://demoqa.com/
        Driver.Navigate().GoToUrl(BaseUrl);

        // Maximizare instanta browser
        Driver.Manage().Window.Maximize();
    }

    [Test]
    public void AddNewRowInTableTest()
    {
        // Define jsExecutor
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");

        // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
        By elementSelector = By.XPath("//h5[text()='Elements']");

        // Initializam un webElement care ne permite interactiunea cu elementul din pagina
        IWebElement elementButton = Driver.FindElement(elementSelector);

        // Dam click pe element
        elementButton.Click();

        // Definim si initializam selector-ul pentru "Web Tables" side menu option
        By webTableSelector = By.XPath("//span[text()='Web Tables']");

        // Initialiam webElement-ul pentru WebTables
        IWebElement webTableOption = Driver.FindElement(webTableSelector);

        // Dam click pe Web Tables option
        webTableOption.Click();

        // Definim si initializam selectorul pentru "Add" button
        By addButtonSelector = By.Id("addNewRecordButton");
        IWebElement addButton = Driver.FindElement(addButtonSelector);
        addButton.Click();

        By firstNameSelector = By.Id("firstName");
        IWebElement firstName = Driver.FindElement(firstNameSelector);
        firstName.SendKeys(FirstName);

        By lastNameSelector = By.Id("lastName");
        IWebElement lastName = Driver.FindElement(lastNameSelector);
        lastName.SendKeys(LastName);

        By emailSelector = By.Id("userEmail");
        IWebElement email = Driver.FindElement(emailSelector);
        email.SendKeys(Email);

        By ageSelector = By.Id("age");
        IWebElement age = Driver.FindElement(ageSelector);
        age.SendKeys(Age);

        By salarySelector = By.Id("salary");
        IWebElement salary = Driver.FindElement(salarySelector);
        salary.SendKeys(Salary);

        By departmentSelector = By.Id("department");
        IWebElement department = Driver.FindElement(departmentSelector);
        department.SendKeys(Department);

        By submitButtonSelector = By.Id("submit");
        IWebElement submitButton = Driver.FindElement(submitButtonSelector);
        submitButton.Click();

        // Output 
        var nonEmptyRowsSelector = Driver.FindElements(By.XPath("//div[@class='rt-tbody']//div[@role='rowgroup'][.//div[@class='action-buttons']]"));
        var nonEmptyRowsSelector2 = Driver.FindElements(By.XPath("//div[@class='rt-tbody']//div[@role='row' and contains(@class,'-padRow') = false]"));

        By outputRowSelector = By.XPath("//div[@class='rt-tbody']//div[@role='rowgroup'][.//div[@class='action-buttons']][4]");
        IWebElement outputRow = Driver.FindElement(outputRowSelector);
        string outputRowText = outputRow.Text;

        // Assert
        Thread.Sleep(5000);

        Assert.That(nonEmptyRowsSelector.Count == 4);
        Assert.That(nonEmptyRowsSelector2.Count == 4);

        Assert.That(outputRowText.Contains(FirstName));
        Assert.That(outputRowText.Contains(LastName));
        Assert.That(outputRowText.Contains(Email));
        Assert.That(outputRowText.Contains(Age));
        Assert.That(outputRowText.Contains(Salary));
        Assert.That(outputRowText.Contains(Department));

    }

    [TearDown]
    public void CleanUp()
    {
        if (Driver != null)
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
