namespace DesignPatterns.StrategyPatternTask
{
    public interface ISocialMediaStrategy
    {
        void ConnectToSocialMedia(string name);
        void Share(string message);
    }
}
