using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionMethods.Models
{
    public static class ExtensionClass
    {
        public static string ToLowerAndReplace(this string param)
        {
            return param
                .ToLower()
                .Replace("/", "")
                .Replace("%", "")
                .Replace("½", "")
                .Replace("?", "")
                .Replace(";", "")
                .Replace(",", "")
                .Replace("$", "")
                .Replace("#", "")
                .Replace("&", "");
        }
    }
}