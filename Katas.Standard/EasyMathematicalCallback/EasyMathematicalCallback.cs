using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Standard.EasyMathematicalCallback
{
    public static class EasyMathematicalCallback
    {
        public static int[] ProcessArray(int[] arr, Func<int, int> callback)
        {
            return arr.Select(x=> callback(x)).ToArray();
        }
    }
}
