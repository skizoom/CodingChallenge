using API.Controllers;
using Xunit;

namespace API.Tests
{
    public class HotelsControllerUnitTest
    {
        [Fact]
        public async void FirstTest()
        {
            var controller = new HotelsController();

            var response = await controller.Get();

            Assert.True(false);
        }
    }
}