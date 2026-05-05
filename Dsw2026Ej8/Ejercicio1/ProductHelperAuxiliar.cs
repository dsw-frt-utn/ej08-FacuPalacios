using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio1
{
    public partial class ProductHelperAuxiliar
    {
        private const string SimboloMoneda = "$";
        private string PrecioMoneda(decimal price)
        {
            return $"{SimboloMoneda}{price:N2}";
        }
    }
}
