namespace API.Delivery
{
    public class USPS : IDeliveryProvider
    {
        public decimal PriceCalculation(decimal value)
        {
            return value * (decimal)3.2;
        }
    }
}
