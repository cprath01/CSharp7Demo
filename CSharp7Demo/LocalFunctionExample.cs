using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demo
{
    public class LocalFunctionExample
    {
        public string FigSequenceBuilder(int numberOfElements, int startFirst = 0, int startSecond = 1)
        {
            var stringBuilder = new StringBuilder();
            int elementCount = 2;

            stringBuilder.Append($"{startFirst}, {startSecond}");

            FibNumber(startFirst, startSecond);

            return stringBuilder.ToString();


            void FibNumber(int first, int second)
            {
                int nextNumber = first + second;

                stringBuilder.Append($", {nextNumber}");

                elementCount++;

                if (elementCount < numberOfElements)
                    FibNumber(second, nextNumber);
            }
        }
    }
}
