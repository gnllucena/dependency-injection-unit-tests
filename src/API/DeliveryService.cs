using API.Delivery;

namespace API
{
    public interface IDeliveryService
    {
        decimal Calculate(decimal price);
    }

    public class DeliveryService : IDeliveryService
    {
        private IDeliveryProvider _delivery;

        public DeliveryService(IDeliveryProvider delivery)
        {
            _delivery = delivery;
        }

        public decimal Calculate(decimal price)
        {
            decimal calculation = 0;

            try
            {
                calculation = _delivery.PriceCalculation(price);
            }
            catch (Exception ex)
            {
                calculation = 999;
            }

            return calculation;
        }
    }
}
