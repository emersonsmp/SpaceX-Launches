using MyApp.Detail.View;

namespace MyApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("detail", typeof(DetailView));
        }
    }
}
