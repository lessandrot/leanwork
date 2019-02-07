using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Leanwork.Dominio.Utilidades
{
    public static class Extensoes
    {
        public static string SomenteNumeros(this string valor) => string.Join(string.Empty, Regex.Split(valor, @"[^\d]"));

        public static IEnumerable<char> DeTrasParaFrente(this string valor)
        {
            var invertido = valor.ToCharArray();
            Array.Reverse(invertido);
            return invertido;
        }

        public static bool EhImpar(this int valor) => valor % 2 != 0;

        public static int SomeDigitos(this int valor)
        {
            var soma = 0;

            foreach(var digito in valor.ToString().ToCharArray())
            {
                soma += int.Parse(digito.ToString());
            }

            return soma;
        }
    }
}