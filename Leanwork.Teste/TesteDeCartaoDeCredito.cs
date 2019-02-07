using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leanwork.Dominio;

namespace Leanwork.Teste
{
    [TestClass]
    public class TesteDeCartaoDeCredito
    {
        [TestMethod]
        public void DadoUmCartaoVisa_ComNumero4111111111111111_EsteDeveSerValido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("4111111111111111");
            Assert.IsTrue(cartao is CartaoDeCreditoVisa);
            Assert.IsTrue(cartao.EhNumeroValido);
            Assert.AreEqual("VISA: 4111111111111111 (válido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoVisa_ComNumero4012888888881881_EsteDeveSerValido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("4012888888881881");
            Assert.IsTrue(cartao is CartaoDeCreditoVisa);
            Assert.IsTrue(cartao.EhNumeroValido);
            Assert.AreEqual("VISA: 4012888888881881 (válido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoVisa_ComNumero4111111111111_EsteDeveSerInvalido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("4111111111111");
            Assert.IsTrue(cartao is CartaoDeCreditoVisa);
            Assert.IsFalse(cartao.EhNumeroValido);
            Assert.AreEqual("VISA: 4111111111111 (inválido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoMasterCard_ComNumero5105105105105100_EsteDeveSerValido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("5105105105105100");
            Assert.IsTrue(cartao is CartaoDeCreditoMasterCard);
            Assert.IsTrue(cartao.EhNumeroValido);
            Assert.AreEqual("MasterCard: 5105105105105100 (válido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoMasterCard_ComNumero5105105105105106_EsteDeveSerInvalido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("5105 1051 0510 5106");
            Assert.IsTrue(cartao is CartaoDeCreditoMasterCard);
            Assert.IsFalse(cartao.EhNumeroValido);
            Assert.AreEqual("MasterCard: 5105105105105106 (inválido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoAMEX_ComNumero378282246310005_EsteDeveSerValido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("378282246310005");
            Assert.IsTrue(cartao is CartaoDeCreditoAMEX);
            Assert.IsTrue(cartao.EhNumeroValido);
            Assert.AreEqual("AMEX: 378282246310005 (válido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoDiscover_ComNumero6011111111111117_EsteDeveSerValido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("6011111111111117");
            Assert.IsTrue(cartao is CartaoDeCreditoDiscover);
            Assert.IsTrue(cartao.EhNumeroValido);
            Assert.AreEqual("Discover: 6011111111111117 (válido)", cartao.MensagemDeValidacao);
        }

        [TestMethod]
        public void DadoUmCartaoDesconhecido_ComNumero9111111111111111_EsteDeveSerInvalido()
        {
            var cartao = FabricaDeCartaoDeCredito.Crie("9111111111111111");
            Assert.IsTrue(cartao is CartaoDeCreditoDesconhecido);
            Assert.IsFalse(cartao.EhNumeroValido);
            Assert.AreEqual("Desconhecido: 9111111111111111 (inválido)", cartao.MensagemDeValidacao);
        }
    }
}