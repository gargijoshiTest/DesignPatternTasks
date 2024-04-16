namespace DesignPatterns.StrategyPatternTask
{
    public class PhoneCameraApp
    {
        private ISocialMediaStrategy socialMediaStrategy;

        public void SetSocialMediaStrategy(ISocialMediaStrategy socialMediaStrategy)
        {
            this.socialMediaStrategy = socialMediaStrategy;
        }

        public void Share(String message)
        {
            this.socialMediaStrategy.Share(message);
        }

        // Other methods...
    }
}
