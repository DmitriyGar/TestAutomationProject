using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationProject.Models
{
    public class AppConfig
    {
        public string Environment { get; set; }
        public string Url { get; set; }
        public IList<User> Users { get; set; }
    }
}
