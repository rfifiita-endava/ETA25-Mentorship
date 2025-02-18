using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace ConsoleAppETA25.Automation.Session7;

public class ActionsClassTests
{
    public IWebDriver Driver;
    public Actions Actions;
    public const string BaseUrl = "https://demoqa.com/";

    // Define jsExecutor
    IJavaScriptExecutor jsExecutor;

    [SetUp]
    public void Setup()
    {
        // Initializare driver Chrome & pornire instanta browser
        Driver = new ChromeDriver();

        // Initializare driver actions
        Actions = new Actions(Driver);

        // Navigam la pagina de HOME: https://demoqa.com/
        Driver.Navigate().GoToUrl(BaseUrl);

        // Maximizare instanta browser
        Driver.Manage().Window.Maximize();

        // Initializare jsExecutor
        jsExecutor = (IJavaScriptExecutor)Driver;

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");
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

    [Test]
    public void HoverTest()
    {
        AccessSpecificPage("Widgets", "Tool Tips", true);

        IWebElement button = Driver.FindElement(By.Id("toolTipButton"));

        Actions.MoveToElement(button).Build().Perform();

        Thread.Sleep(3000);
    }

    [Test]
    public void MenuHoverTest()
    {
        AccessSpecificPage("Widgets", "Menu", true);

        IWebElement mainMenu2 = Driver.FindElement(By.XPath("//li/a[text()=\"Main Item 2\"]"));
        IWebElement subMenu3 = Driver.FindElement(By.XPath("//li/a[text()=\"SUB SUB LIST »\"]"));
        IWebElement subSubMenu2 = Driver.FindElement(By.XPath("//li/a[text()=\"Sub Sub Item 2\"]"));

        Actions.MoveToElement(mainMenu2)
            .MoveToElement(subMenu3)
            .MoveToElement(subSubMenu2)
            .Click()
            .Build().Perform();

        Thread.Sleep(3000);
    }

    [Test]
    public void MoveSliderTest()
    {
        AccessSpecificPage("Widgets", "Slider");

        IWebElement slider = Driver.FindElement(By.XPath("//input[@type=\"range\"]"));

        Actions.MoveToElement(slider)
            .MoveByOffset(-120,0) // every 6 pixels should equal to 1 value
            .Click()
            .Build().Perform();

        Thread.Sleep(3000);

        Assert.That(slider.GetDomAttribute("value") == "30");
    }

    public void AccessSpecificPage(string cardName, string menuOptionName, bool shouldIntermediateScroll = false)
    {
        By cardSelector = By.XPath($"//h5[text()='{cardName}']");
        IWebElement card = Driver.FindElement(cardSelector);
        card.Click();

        // intermediate scroll
        if (shouldIntermediateScroll) 
        { 
            Actions.ScrollByAmount(0, 1000).Build().Perform();
        }

        By menuOptionSelector = By.XPath($"//span[text()='{menuOptionName}']");
        IWebElement menuOption = Driver.FindElement(menuOptionSelector);
        menuOption.Click();

        // scroll using Actions class
        Actions
            .ScrollByAmount(0, 300)
            .Build()
            .Perform();
    }
}
