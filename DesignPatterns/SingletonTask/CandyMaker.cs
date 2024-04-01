namespace DesignPatterns
{
    public sealed class CandyMaker
    {
        private bool _isBoilerEmpty;
        private bool _isContentBoiled;

        private static readonly Lazy<CandyMaker> _lazyInstance = new Lazy<CandyMaker>(() => new CandyMaker());

        public static CandyMaker Instance => _lazyInstance.Value;

        public bool IsBoilerEmpty => _isBoilerEmpty;
        public bool IsContentBoiled => _isContentBoiled;

        //This code is only started when the boiler is empty
        private CandyMaker()
        {
            _isBoilerEmpty = true;
            _isContentBoiled = false;
        }

        //to fill the boiler it must be empty, and once its full, 
        //we set the empty and boiled flags 
        public void FillBoiler()
        {
            if (IsBoilerEmpty)
            {
                _isBoilerEmpty = false;
                _isContentBoiled = false;
                // fill the candyMaker with milk and choclate mix
            }
        }

        //To drain the boiler, it must be full(non-empty) and also boiled.
        //once it is drained, we set the empty back to true 
        public void DrainBoiler()
        {
            if (!IsBoilerEmpty && IsContentBoiled)
            {
                // drain the boiled milk and chocolate
                _isBoilerEmpty = true;
            }
        }

        //to boil the mixture the boiler has to be full and not already boiled. 
        //once its boiled we set the boiled flag to true
        public void BoilContents()
        {
            if (!IsBoilerEmpty && !IsContentBoiled)
            {
                // bring the content to boil
                _isContentBoiled = true;
            }
        }
    }
}
