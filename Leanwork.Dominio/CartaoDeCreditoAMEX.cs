namespace Leanwork.Dominio
{
    public class CartaoDeCreditoAMEX : CartaoDeCredito
    {
        public override string Tipo => "AMEX";

        public override bool EhTipoValido
        {
            get
            {
                var comprimento = Numero.Length;
                if (comprimento == 15)
                {
                    int.TryParse(Numero.Substring(0, 2), out var numeroInicial);
                    if (numeroInicial == 34 || numeroInicial == 37) return true;
                }

                return false;
            }
        }

        internal CartaoDeCreditoAMEX(string numero) : base(numero) { }
    }
}