using System;

namespace CSharp7Demo
{
    public class TupleExample
    {
        private int first;
        private int second;
        public TupleExample(int x, int y)
        {
            first = x;
            second = y;
        }


        public (int, int) GetNumbers() =>  (first, second);

        public (int x, int y) GetNumbers2() => GetNumbers();

    }
}
