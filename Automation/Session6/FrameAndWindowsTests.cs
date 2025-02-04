using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleAppETA25.Automation.Session6;

public class FrameAndWindowsTests
{
    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";

    // Define jsExecutor
    IJavaScriptExecutor jsExecutor;

    [SetUp]
    public void Setup()
    {
        // Initializare driver Chrome & pornire instanta browser
        Driver = new ChromeDriver();

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
    public void FramesTest()
    {
        AccessFramesPage();

        // Definim un selector pentru iFrame
        By iFrameSelector = By.Id("frame1");

        // Initializam un WebElement pentru iFrame
        IWebElement iFrame1 = Driver.FindElement(iFrameSelector);

        // Switch context to correct window/tab/iframe
        Driver.SwitchTo().Frame(iFrame1);

        // Definim un selector pentru identificarea iFrame headingului
        By headingSelector = By.Id("sampleHeading");

        // Initializam un IWebElement
        IWebElement iFrameHeading = Driver.FindElement(headingSelector);
        string iFrameHeadingText = iFrameHeading.Text;
        string validationText = "This is a sample page";

        Assert.That(iFrameHeadingText, Is.EqualTo(validationText));
    }

    [Test]
    public void FramesSwitchBackTest()
    {
        AccessNestedFramesPage();

        // Definim un selector pentru iFrame
        By iFrameSelector = By.Id("frame1");

        // Initializam un WebElement pentru iFrame
        IWebElement iFrameParent = Driver.FindElement(iFrameSelector);

        // Switch context to correct window/tab/iframe
        // Parent iFrame
        Driver.SwitchTo().Frame(iFrameParent);

        // Definim un selector pentru body
        By bodySelector = By.TagName("body");

        //Definim o variabila pentru text
        string bodyText = Driver.FindElement(bodySelector).Text;

        Assert.That(bodyText, Is.EqualTo("Parent frame"));

        // Definim un selector pentru iFrame Child
        By iFrameChildSelector = By.TagName("iframe");

        // Initializam un WebElement pentru iFrame
        IWebElement iFrameChild = Driver.FindElement(iFrameChildSelector);

        // Switch context to correct window/tab/iframe
        // Child iFrame
        Driver.SwitchTo().Frame(iFrameChild);

        // Definim un selector pentru identificarea iFrame paragraph
        By paragraphSelector = By.TagName("p");

        // Initializam un IWebElement
        IWebElement iFrameParagraph = Driver.FindElement(paragraphSelector);
        string iFrameParagraphText = iFrameParagraph.Text;
        string childValidationText = "Child Iframe";

        Assert.That(iFrameParagraphText, Is.EqualTo(childValidationText));

        // Return to main window/page
        Driver.SwitchTo().DefaultContent();

        By h1Selector = By.TagName("h1");

        string h1Text = Driver.FindElement(h1Selector).Text;

        Assert.That(h1Text, Is.EqualTo("Nested Frames"));
    }

    [Test]
    public void BrowserWindowsTest()
    {
        AccessBrowserWindowsPage();

        By tabButtonSelector = By.Id("windowButton");

        // Open a new tab
        IWebElement tabButton = Driver.FindElement(tabButtonSelector);
        tabButton.Click();

        // Create a new list for tabs/windows
        List<string> tabsList = new List<string>(Driver.WindowHandles);

        // Switch to newly opened tab
        //Driver.SwitchTo().Window("demoqa.com/sample");
        Driver.SwitchTo().Window(tabsList[1]);

        // New tab - heading
        IWebElement newTabHeading = Driver.FindElement(By.TagName("h1"));

        Assert.That(newTabHeading.Text, Is.EqualTo("This is a sample page"));

        // initial tab name
        string initialTabHandle = tabsList[0];
        string newTabName = Driver.Title;

        // Switch to initial tab
        Driver.SwitchTo().Window(initialTabHandle);
        string initalTabName = Driver.Title;
    }

    [Test]
    public void BrowserWindowsTest2()
    {
        AccessBrowserWindowsPage();

        By windowButtonSelector = By.Id("windowButton");

        // Open a new window
        IWebElement windowButton = Driver.FindElement(windowButtonSelector);
        windowButton.Click();

        // Create a new list for tabs/windows
        List<string> tabsList = new List<string>(Driver.WindowHandles);

        // Switch to newly opened tab
        Driver.SwitchTo().Window(tabsList[1]);

        IWebElement newWindowHeading = Driver.FindElement(By.TagName("h1"));

        Assert.That(newWindowHeading.Text, Is.EqualTo("This is a sample page"));

        // Close window
        Driver.Close();
    }

    public void AccessFramesPage()
    {
        // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
        By frameWindowsSelector = By.XPath("//h5[text()='Alerts, Frame & Windows']");

        // Initializam un webElement care ne permite interactiunea cu elementul din pagina
        IWebElement frameWindowsButton = Driver.FindElement(frameWindowsSelector);

        // Dam click pe element
        frameWindowsButton.Click();

        // Definim si initializam selector-ul pentru "Frames" side menu option
        By framesSelector = By.XPath("//span[text()='Frames']");

        // Initializam webElement-ul pentru Frames
        IWebElement framesOption = Driver.FindElement(framesSelector);

        // Dam click pe Frames option
        framesOption.Click();

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");
    }

    public void AccessNestedFramesPage()
    {
        // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
        By frameWindowsSelector = By.XPath("//h5[text()='Alerts, Frame & Windows']");

        // Initializam un webElement care ne permite interactiunea cu elementul din pagina
        IWebElement frameWindowsButton = Driver.FindElement(frameWindowsSelector);

        // Dam click pe element
        frameWindowsButton.Click();

        // Definim si initializam selector-ul pentru "Nested Frames" side menu option
        By framesSelector = By.XPath("//span[text()='Nested Frames']");

        // Initializam webElement-ul pentru Frames
        IWebElement framesOption = Driver.FindElement(framesSelector);

        // Dam click pe Frames option
        framesOption.Click();

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");
    }

    public void AccessBrowserWindowsPage()
    {
        // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
        By frameWindowsSelector = By.XPath("//h5[text()='Alerts, Frame & Windows']");

        // Initializam un webElement care ne permite interactiunea cu elementul din pagina
        IWebElement frameWindowsButton = Driver.FindElement(frameWindowsSelector);

        // Dam click pe element
        frameWindowsButton.Click();

        // Definim si initializam selector-ul pentru "Browser Windows" side menu option
        By browserWindowsSelector = By.XPath("//span[text()='Browser Windows']");

        // Initializam webElement-ul pentru Browser Windows
        IWebElement browserWindowsOption = Driver.FindElement(browserWindowsSelector);

        // Dam click pe Browser Windows option
        browserWindowsOption.Click();

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");
    }
}
