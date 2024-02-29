using MyApp.Detail.Model;
using MyApp.Detail.View;
using MyApp.Detail.ViewModel;
using MyApp.Home.Models;
using MyApp.Home.Service;
using MyApp.Home.Service.Dto.Response;
using MyApp.Providers;
using MyApp.Shared.ViewModel;
using Newtonsoft.Json;
using Refit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyApp.Home.ViewModels
{
    public class HomeViewModel : BaseViewModel<HomeModel>
    {
        public IService _service;
        public ICommand DoItemCommand { get; private set; }

        public HomeViewModel(IService service)
        {
            _service = service;

            DoItemCommand = new Command<LaunchModel>(async (item) => await OnButtonClicked(item));
            Init();
        }

        private void Init()
        {
            _= InitDelayedAsync(LoadLaunchsAsync);
        }

        public async Task LoadLaunchsAsync()
        {
            try
            {
                var response = await _service.GetLaunchsInfoAsync();
                Model.LauchList = MapperProvider.Instance.MapList<LaunchModel>(response);
            }
            catch (ApiException e)
            {
                var aux = e as ApiException;
            }
        }

        private async Task OnButtonClicked(LaunchModel selectedItem)
        {
            var item = selectedItem;
            var vm = new DetailViewModel(item);
            await Shell.Current.Navigation.PushAsync(new DetailView(vm));
        }
    }
}
