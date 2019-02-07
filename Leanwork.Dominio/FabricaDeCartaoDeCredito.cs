namespace Leanwork.Dominio
{
    public class FabricaDeCartaoDeCredito
    {
        private FabricaDeCartaoDeCredito() { }

        static public CartaoDeCredito Crie(string numero)
        {
            CartaoDeCredito cartao = new CartaoDeCreditoVisa(numero);
            if (cartao.EhTipoValido) return cartao;

            cartao = new CartaoDeCreditoMasterCard(numero);
            if (cartao.EhTipoValido) return cartao;

            cartao = new CartaoDeCreditoAMEX(numero);
            if (cartao.EhTipoValido) return cartao;

            cartao = new CartaoDeCreditoDiscover(numero);
            if (cartao.EhTipoValido) return cartao;

            return new CartaoDeCreditoDesconhecido(numero);
        }
    }
}