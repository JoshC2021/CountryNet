using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCountriesNet.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string OfficialLanguage { get; set; }
        public string HelloWorld { get; set; }
        public string Description { get; set; }
        public string[] PrimaryColors { get; set; }
    }
}
