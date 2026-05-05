using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
                return "SIN-CODIGO";

            string trimmed = code.Trim();
            string upper = trimmed.ToUpper();
            string result = upper.Replace(' ', '-');

            return result;
        }
    }
}
