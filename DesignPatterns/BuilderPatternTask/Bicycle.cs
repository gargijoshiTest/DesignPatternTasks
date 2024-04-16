namespace DesignPatterns.BuilderPatternTask
{
    public class Bicycle
    {
        public bool HasGears { get; set; }
        public bool HasDoubleStand { get; set; }
        public bool HasDoubleSeat { get; set; }
        public bool HasCarrier { get; set; }
    }

    public class BicycleBuilder
    {
        private Bicycle _bicycle = new Bicycle();

        public BicycleBuilder WithGears()
        {
            _bicycle.HasGears = true;
            return this;
        }

        public BicycleBuilder WithDoubleStand()
        {
            _bicycle.HasDoubleStand = true;
            return this;
        }

        public BicycleBuilder WithDoubleSeat()
        {
            _bicycle.HasDoubleSeat = true;
            return this;
        }

        public BicycleBuilder WithCarrier()
        {
            _bicycle.HasCarrier = true;
            return this;
        }

        public Bicycle Build()
        {
            return _bicycle;
        }
    }
}
