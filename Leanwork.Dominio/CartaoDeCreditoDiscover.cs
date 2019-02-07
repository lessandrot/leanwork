namespace Leanwork.Dominio
{
    public class CartaoDeCreditoDiscover : CartaoDeCredito
    {
        public override string Tipo => "Discover";

        public override bool EhTipoValido
        {
            get
            {
                var comprimento = Numero.Length;
                if (comprimento == 16)
                {
                    int.TryParse(Numero.Substring(0, 4), out var numeroInicial);
                    if (numeroInicial == 6011) return true;
                }

                return false;
            }
        }

        internal CartaoDeCreditoDiscover(string numero) : base(numero) { }
    }
}