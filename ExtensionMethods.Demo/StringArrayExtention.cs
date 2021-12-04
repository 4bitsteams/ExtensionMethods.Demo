using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Demo
{
    public static class StringArrayExtention
    {
        public static IEnumerable<int> Filter(this IEnumerable<string> items,Func<int,bool> func)
        {
            return items.Select(x => Convert.ToInt32(x)).Where(x=>func(x));
        }
    }
}
