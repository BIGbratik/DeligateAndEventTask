using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDeligateAndEventTask
{
    public static class MyCollectionAnalyzer
    {
        public static T GetMax<T> (this IEnumerable<T> collection, Func<T, double> convertToNumber)
        {
            var maxValue = double.MinValue;
            T maxItem = default;


            foreach (var item in collection)
            {
                var currentNum = convertToNumber(item);
                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                    maxItem = item;
                }
            }

            return maxItem;
        }
    }
}
