using System;
using Leanwork.Dominio.Utilidades;

namespace Leanwork.Dominio
{
    public abstract class CartaoDeCredito
    {
        abstract public string Tipo { get; }
        public string Numero { get; }

        abstract public bool EhTipoValido { get; }
        virtual public bool EhNumeroValido => Calculo.EhModuloDe10(Numero);

        virtual public string MensagemDeValidacao
        {
            get
            {
                var validacao = EhNumeroValido ? "válido" : "inválido";
                return $"{Tipo}: {Numero} ({validacao})";
            }
        }

        internal CartaoDeCredito(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero)) throw new Exception("O número do cartão deve ser informado.");

            numero = numero.SomenteNumeros();
            if (string.IsNullOrWhiteSpace(numero)) throw new Exception("O número do cartão não deve conter letras e caracteres especiais.");
       
            Numero = numero;
        }
    }
}