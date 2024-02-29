using MyApp.Home.Service.Dto.Response;
using MyApp.Shared.Models;
using System.Collections.ObjectModel;

namespace MyApp.Home.Models
{
    public class HomeModel : BaseModel
    {
        public List<LaunchModel> LauchList { get; set; } = new List<LaunchModel>();

        public string EntryString { get; set; } = "TEste";
    }
}
