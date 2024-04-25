namespace DesignPatterns.FactoryPatternTask.Task1
{
    internal class BrowserFactory
    {
    }
}

public class BrowserFactory
{
    public static IBrowser CreateBrowser(string browserType)
    {
        switch (browserType)
        {
            case "Chrome":
                return new MyChromeDriver();
            case "Firefox":
                return new MyFirefoxDriver();
            case "IE":
                return new MyIEDriver();
            default:
                throw new Exception("Invalid browser type");
        }
    }
}