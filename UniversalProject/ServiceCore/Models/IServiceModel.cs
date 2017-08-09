using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCore.Models
{
    public interface IServiceModel
    {
        string Name { get; }
        string Url { get; }
        string Description { get; }
        string Version { get; }
        bool IsHttpsOnly { get; }
        RequestType Request { get; }
        IEnumerable<IProperty> Parameters { get; }
        DataType ReturnType { get; }
    }
}
