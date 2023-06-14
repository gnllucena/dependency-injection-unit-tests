namespace API.Delivery
{
    public interface IDeliveryProvider
    {
        decimal PriceCalculation(decimal value);
    }
}
