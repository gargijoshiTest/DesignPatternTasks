// See https://aka.ms/new-console-template for more information
using DesignPatterns;
//Singleton
Console.WriteLine("Hello, World!");
CandyMaker candyMaker = CandyMaker.Instance;

//FactoryPattern - Task 1 
IBrowser browser = BrowserFactory.CreateBrowser("Chrome");
browser.Initialize();

//FactoryPattern - Task 2

CustomBrowserFactory factory = new ChromeDriverFactory();
ICustomBrowser customBrowser = factory.CreateBrowser();
customBrowser.Initialize();

factory = new ChromeDriverWithCapabilitiesFactory();
customBrowser = factory.CreateBrowser();
customBrowser.Initialize();