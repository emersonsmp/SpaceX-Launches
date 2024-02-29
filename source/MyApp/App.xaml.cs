using MyApp.Bootstraps;

//[assembly: ExportFont("BwModelica-ExtraBold.otf")]
//[assembly: ExportFont("BwModelica-Regular.otf")]
//[assembly: ExportFont("BwModelica-Bold.otf")]
//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
