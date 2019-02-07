namespace Leanwork.Dominio
{
    public class CartaoDeCreditoMasterCard : CartaoDeCredito
    {
        public override string Tipo => "MasterCard";

        public override bool EhTipoValido
        {
            get
            {
                var comprimento = Numero.Length;
                if (comprimento == 16)
                {
                    int.TryParse(Numero.Substring(0, 2), out var numeroInicial);
                    if (numeroInicial >= 51 && numeroInicial <= 55) return true;
                }

                return false;
            }
        }

        internal CartaoDeCreditoMasterCard(string numero) : base(numero) { }
    }
}