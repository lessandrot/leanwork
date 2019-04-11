using System.Collections.Generic;
using System.Linq;

namespace Leanwork.Dominio.Utilidades
{
    public class Calculo
    {
        public static bool EhModuloDe10(string digitos)
        {
            var digitosNumericos = digitos?.SomenteNumeros();
            if (string.IsNullOrWhiteSpace(digitosNumericos)) return false;

            var sequencia = new List<int>();
            var digitosInvertidos = digitosNumericos.DeTrasParaFrente();

            foreach (var item in digitosInvertidos.Select((Digito, Indice) => new { Digito, Indice }))
            {
                
                var numero = int.Parse(item.Digito.ToString());

                if (item.Indice.EhImpar())
                {
                    numero *= 2;
                    numero = numero.SomeDigitos();
                }

                sequencia.Add(numero);
            }

            var resto = sequencia.Sum() % 10;
            // Teste git
            return resto == 0;
        }
    }
}