using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Dsw2026Ej8.Ejercicio4
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            List<int> notasValidas = new List<int>();

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
                notasValidas.Add(nota1.Value);
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
                notasValidas.Add(nota2.Value);
            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
                notasValidas.Add(nota3.Value);

            if (notasValidas.Count == 0)
                return 0;

            return notasValidas.Average();
        }
    }
}
