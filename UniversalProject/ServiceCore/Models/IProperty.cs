using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCore.Models
{
    public interface IProperty
    {
        string Name { get; }
        bool IsRequired { get; }
        int MaxLength { get; }
        int MinLength { get; }
        DataType DataType { get; }
    }
}
