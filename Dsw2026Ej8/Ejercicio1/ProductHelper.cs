using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio1
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioConFormato = price.ToString("C");
            string etiqueta = $"[{code}] {description} - {precioConFormato}";
            return etiqueta;
        }
    }
}
