using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo
{
    public class ThrowExceptionExample
    {
        public int? Id;

        public ThrowExceptionExample(int? id) => this.Id = id ?? throw new Exception($"{nameof(this.Id)} was null");
    }
}
