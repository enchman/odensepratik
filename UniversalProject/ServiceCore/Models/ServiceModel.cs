using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCore.Models
{
    public class ServiceModel : IServiceModel
    {
        public string ServiceName { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public bool IsHttpsOnly { get; set; }

        public RequestType Request { get; set; }

        public IEnumerable<IProperty> Parameters { get; set; }

        public DataType ReturnType { get; set; }
    }
}
