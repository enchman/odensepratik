using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCore.Models
{
    public class Property : IProperty
    {
        public string Name { get; set; }

        public bool IsRequired { get; set; }

        public DataType DataType { get; set; }

        public int MaxLength { get; set; }

        public int MinLength { get; set; }
    }
}
