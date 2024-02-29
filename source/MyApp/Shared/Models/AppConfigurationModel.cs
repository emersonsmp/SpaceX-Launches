namespace MyApp.Shared.Models
{
    public class AppConfigurationModel
    {
        public ApiModel Api { get; set; } = new ApiModel();

        public class ApiModel : BaseAppConfigurationModel { }

        public class BaseAppConfigurationModel
        {
            public string Homol { get; set; }
            public string Prod { get; set; }
            public string Debug { get; set; }
            public string Staging { get; set; }
        }
    }
}
