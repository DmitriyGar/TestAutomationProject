using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Models;

namespace TestAutomationProject.Utilities
{
    //this class is for deserialization of test data from configuration.json
    public static class TestData                                    
    {
        private static string _json => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Tests/configuration.json");
        public static User PositiveUser {get; }
        public static User NegativeUser { get; }
        public static string Url { get; }

        static TestData()
        {
            string json = File.ReadAllText(_json);
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            Url = config.Url;
            PositiveUser = config.Users.First(i => i.Type == "positive");
            NegativeUser = config.Users.First(i => i.Type == "negative");
        }
    }

}
