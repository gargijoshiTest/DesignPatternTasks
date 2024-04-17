namespace DesignPatterns.DecoratorPatternTask
{
    public class Widget : WebpageDecorator
    {
        private int rank = 1;
        public Widget(IWebpage webpage) : base(webpage) { }
        public override int GetRank()
        {
            return base.GetRank() + rank;
        }
    }
}
