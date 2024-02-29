using MyApp.Shared.Models;
using MyApp.Utils.Constants;
using Newtonsoft.Json;
using System.Reflection;

namespace MyApp.Providers
{
    public class AppConfigurationProvider
    {
        private static readonly Lazy<AppConfigurationProvider> _instance = _instance ??= new Lazy<AppConfigurationProvider>(() => ReadFileConfigurationAsync());

        public static AppConfigurationProvider Instance => _instance.Value;

        private AppConfigurationProvider()
        {
        }

        public string ApiUrl { get; set; }


        private static AppConfigurationProvider ReadFileConfigurationAsync()
        { 
            var config = new AppConfigurationProvider();

            string resourceName = $"{SharedConstant.ConfigurationPath}.{SharedConstant.JsonApp}";
            Stream stream = typeof(App).Assembly.GetManifestResourceStream(resourceName) ?? Stream.Null;
            using var reader = new StreamReader(stream);
            var file = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<AppConfigurationModel>(file);

            config.ApiUrl = model.Api.Prod;

#if DEBUG
            config.ApiUrl = model.Api.Debug;
#endif
            return config;
        }
    }
}
