public class ChromeDriverWithCapabilitiesFactory : CustomBrowserFactory
{
    public override ICustomBrowser CreateBrowser()
    {
        return new MyChromeDriverWithCapabilities();
    }
}
