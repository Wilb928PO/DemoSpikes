using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.ClassLibrary
{
    public static class ExtMethods
    {
        public static string NewStringMethod(this string str)
        {
            return "Inside the extension method";
        }
    }
}
