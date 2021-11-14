using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adress_Book.MyExtension
{
    static class MyExtensionClass
    {
        public static bool IsNullOrEmpty<T>(this T[] array) where T : class
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return array.All(item => item == null);
        }
        public static bool IsNullOrEmpty2<T>(this T[] array) where T : class
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return array.All(item => item == null);
        }
    }
}
