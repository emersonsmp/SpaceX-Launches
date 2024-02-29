
using MyApp.Home.ViewModels;

namespace MyApp.Home.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView(HomeViewModel homeViewModel)
        {
            InitializeComponent();
            BindingContext = homeViewModel;
        }
    }

}
