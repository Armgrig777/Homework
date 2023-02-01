using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Extensions
    {

        public static string AddSpaceBetween(this string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    stringBuilder.Append(" ");
                }

                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString().Trim();
        }

    }
}
