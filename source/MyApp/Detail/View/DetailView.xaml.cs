using MyApp.Detail.ViewModel;

namespace MyApp.Detail.View;

public partial class DetailView : ContentPage
{
	public DetailView(DetailViewModel detailViewModel)
	{
		InitializeComponent();
		BindingContext = detailViewModel;
    }
}