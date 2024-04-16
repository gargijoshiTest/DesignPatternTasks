public class ChromeDriverFactory : CustomBrowserFactory
{
    public override ICustomBrowser CreateBrowser()
    {
        return new MyCustomChromeDriver();
    }
}
