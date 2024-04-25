namespace DesignPatterns.StrategyPatternTask
{
    public class TextShareStrategy : ISocialMediaStrategy
    {
        public void ConnectToSocialMedia(string name)
        {
            // Implement text share connect functionality
            Console.WriteLine("Connecting via text.....");
        }
        public void Share(string message)
        {
            // Implement text share functionality
            Console.WriteLine("Message '" + message + "' shared via Text");
        }
    }
}
