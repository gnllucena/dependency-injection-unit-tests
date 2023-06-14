namespace API.Delivery
{
    public class UPS : IDeliveryProvider
    {
        public decimal PriceCalculation(decimal value)
        {
            return value * 2;
        }
    }
}
