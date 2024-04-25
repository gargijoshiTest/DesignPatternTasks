namespace DesignPatterns.DecoratorPatternTask
{
    public class WebpageDecorator : IWebpage
    {
        protected IWebpage webpage;
        public WebpageDecorator(IWebpage webpage)
        {
            this.webpage = webpage;
        }
        public virtual int GetRank()
        {
            return this.webpage.GetRank();
        }
    }
}
