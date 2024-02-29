using Moq;
using MyApp.Home.Service;
using MyApp.Home.Service.Dto.Response;
using MyApp.Home.ViewModels;
namespace MyApp.Test
{
    public class UnitTest
    {
        private Mock<IService> _mockService = new Mock<IService>();

        [Fact]
        public async Task TestLoadLaunchsAsync_Success()
        {
            var mockResponse = new List<LaunchesResponseDto>()
            {
                new LaunchesResponseDto {mission_name="Mission Name"},
                new LaunchesResponseDto {mission_name="Mission Name"},
                new LaunchesResponseDto {mission_name="Mission Name"},
                new LaunchesResponseDto {mission_name="Mission Name"}
            };

            _mockService.Setup(service => service.GetLaunchsInfoAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(mockResponse));

            var viewModel = new HomeViewModel(_mockService.Object);
            await viewModel.LoadLaunchsAsync();

            Assert.NotNull(viewModel.Model.LauchList);
        }
    }
}