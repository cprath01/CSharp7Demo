using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo
{
    public class OutVar
    {
        public int ConvertToInt(object item) 
        {
            if(int.TryParse(item.ToString(), out int newItem))
            {
                return newItem;
            }
            return default;
        }
    }
}
