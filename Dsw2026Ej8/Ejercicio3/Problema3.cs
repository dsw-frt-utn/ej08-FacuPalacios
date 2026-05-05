using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;
            Product copiaProducto = product;

            copiaProducto.SetDescripcion("Descripción modificada");

            return $"{originalValue}-{copiaValor}-{product.Descripcion}";
        }
    }
}
