using API;
using API.Delivery;
using Moq;
using Xunit;

namespace Tests
{
    public class Delivery
    {
        [Fact]
        public void TestCalculation()
        {
            var mockDeliveryProvider = new Mock<IDeliveryProvider>();
            mockDeliveryProvider.Setup(ds => ds.PriceCalculation(It.IsAny<decimal>())).Returns(10);

            // Arrange
            var service = new DeliveryService(mockDeliveryProvider.Object);

            // Act
            var calculation = service.Calculate(1);

            // Assert
            Assert.Equal(10, calculation);
        }

        [Fact]
        public void TestException()
        {
            var mockDeliveryProvider = new Mock<IDeliveryProvider>();
            mockDeliveryProvider.Setup(ds => ds.PriceCalculation(It.IsAny<decimal>())).Throws(new Exception("sad face"));

            // Arrange
            var service = new DeliveryService(mockDeliveryProvider.Object);

            // Act
            var calculation = service.Calculate(1);

            // Assert
            Assert.Equal(999, calculation);
        }
    }
}
