using System.Linq;

namespace Leanwork.Dominio
{
    public class CartaoDeCreditoVisa : CartaoDeCredito
    {
        public override string Tipo => "VISA";

        public override bool EhTipoValido
        {
            get
            {
                var comprimento = Numero.Length;
                if (comprimento == 13 || comprimento == 16)
                {
                    int.TryParse(Numero.First().ToString(), out var numeroInicial);
                    if (numeroInicial == 4) return true;
                }

                return false;
            }
        }

        internal CartaoDeCreditoVisa(string numero) : base(numero) { }
    }
}