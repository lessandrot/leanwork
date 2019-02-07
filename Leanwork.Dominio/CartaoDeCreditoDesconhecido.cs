namespace Leanwork.Dominio
{
    public class CartaoDeCreditoDesconhecido : CartaoDeCredito
    {
        public override string Tipo => "Desconhecido";

        public override bool EhTipoValido => false;
        public override bool EhNumeroValido => false;

        internal CartaoDeCreditoDesconhecido(string numero) : base(numero) { }
    }
}