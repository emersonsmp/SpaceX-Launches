using MyApp.Home.Service.Dto.Response;
using Refit;

namespace MyApp.Home.Service
{
    public interface IService
    {
        [Get("/v3/launches/{id}")]
        Task<LaunchesResponseDto> GetLaunchInfoAsync(string id);

        [Get("/v3/launches?limit={limit}")]
        Task<List<LaunchesResponseDto>> GetLaunchsInfoAsync(string limit = "100");
    }
}
