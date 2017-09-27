using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo
{
    public class RefLocalRefOut
    {
        private MyStruct[] myStructs;

        public RefLocalRefOut() => myStructs = new List<MyStruct> { new MyStruct { Id = 1, value = 987654321 } }.ToArray();

        public ref MyStruct GetStruct()
        {
            return ref myStructs[0];
        }
    }

    public struct MyStruct
    {
        public int Id { get; set; }
        public long value { get; set; }
    }
}
