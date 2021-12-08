using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BeluqaTahir.Applications.Core.Extension
{
    static public partial class Extension
    {
        static public string PlainText(this string text)
        {
            return Regex.Replace(text, @"<[^>]*>", "");
        }
    }
}
