using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Ejercicio3
{
    public class Product
    {
        public string Descripcion { get; private set; }

        public void SetDescripcion(string nuevaDescripcion)
        {
            Descripcion = nuevaDescripcion;
        }
    }
}
