using Microsoft.Maui.ApplicationModel;
using MyApp.Detail.Model;
using MyApp.Home.Service.Dto.Response;
using MyApp.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyApp.Detail.ViewModel
{
    public class DetailViewModel : BaseViewModel<DetailModel>
    {
        public ICommand DoOpenLaunchVideoCommand { get; private set; }
        public DetailViewModel(LaunchModel launch) {
            Model.Launch = launch;
            DoOpenLaunchVideoCommand = new Command( async () => await DoOpenLaunchVideoAsync());
        }

        private async Task DoOpenLaunchVideoAsync()
        {
            Uri uri = new(Model.Launch.links.video_link);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
