namespace DesignPatterns.StrategyPatternTask
{
    public class EmailShareStrategy : ISocialMediaStrategy
    {
        public void ConnectToSocialMedia(string name)
        {
            // Implement email share connect functionality
            Console.WriteLine("Connecting via Email.....");
        }
        public void Share(string message)
        {
            // Implement email share functionality
            Console.WriteLine("Message '" + message + "' shared via Email");
        }
    }
}
