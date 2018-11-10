using System;
using System.Collections.Generic;
using System.Text;

namespace TestPaises.Models
{
    using Newtonsoft.Json;

    public class RegionalBloc
    {
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
