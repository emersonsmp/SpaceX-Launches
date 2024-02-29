using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Utils.Constants
{
    public static class SharedConstant
    {
        public const string ConfigurationPath = "MyApp.Resources.Configuration";

        public const string ConfigLabelBreakLine = "\n";
        public const string JsonApp = "App.json";
        public const string AppSettings = "AppSettings.json";

        public const int CacheTime = 604800000;
        public const int RequestTime = 60000;
        public const int InitDelayTime = 450;

        public const int MaxLength = 20;

        public const string EnvironmentDevelopment = "Desenvolvimento";
        public const string EnvironmentStaging = "Staging";
        public const string EnvironmentHomol = "Homologação";
        public const string EnvironmentHomolTopic = "Homologacao";
    }
}
