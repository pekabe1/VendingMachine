using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class ExtensionMetods
    {
        public static bool In<T>(this T obj, params T[] args)
        {
            return args.Contains(obj);
        }

       
    }
}
