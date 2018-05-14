using CodeItAirlines.src;
using NUnit.Framework;

namespace CodeItAirlines.Test
{
    [TestFixture]
    public class CodeItAirlinesTest
    {
        private Terminal terminal;
        private Aviao aviao;

        [SetUp]
        public void IserirDados()
        {
            terminal = new Terminal();
            aviao = new Aviao();
        }
        [Test]
        public void Deve_Levar_Chefe_E_Piloto_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();
            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }

        [Test]
        public void Deve_Inserir_Oficial_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }

        [Test]
        public void Deve_Inserir_Comissaria_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }

        [Test]
        public void Deve_Inserir_Outro_Oficial_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialDoisAteAviao(terminal.piloto, terminal.oficialDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }
        [Test]
        public void Deve_Inserir_Outra_Comissaria_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialDoisAteAviao(terminal.piloto, terminal.oficialDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaDoisAteAviao(terminal.chefeVoo, terminal.comissariaDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }
        [Test]
        public void Deve_Inserir_Chefe_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialDoisAteAviao(terminal.piloto, terminal.oficialDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaDoisAteAviao(terminal.chefeVoo, terminal.comissariaDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefePolicialAteAviao(terminal.policial, terminal.chefeVoo);
            smartTwo.RetornarPolicialParaTerminal(aviao.policial);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraPresidiario);
        }

        [Test]
        public void Deve_Inserir_Polcial_E_Presidiario_No_Aviao()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialDoisAteAviao(terminal.piloto, terminal.oficialDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefeComissariaDoisAteAviao(terminal.chefeVoo, terminal.comissariaDois);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            smartTwo.TransportarChefePolicialAteAviao(terminal.policial, terminal.chefeVoo);
            smartTwo.RetornarPolicialParaTerminal(aviao.policial);
            smartTwo.TransportarPolicialPresidiarioAteAviao(terminal.policial, terminal.presidiario);
            var regraComissaria = smartTwo.ValidarRegraComissaria();
            var regraOficial = smartTwo.ValidarRegraOficial();
            var regraTerminalVazio = smartTwo.ValidarTerminalTemPessoas();
            var regraPresidiario = smartTwo.ValidarRegraPresidiario();

            Assert.AreEqual(false, regraComissaria || regraOficial || regraTerminalVazio || regraPresidiario);
        }

        [Test]
        public void Deve_Validar_Regra_Oficial()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            smartTwo.TransportarPilotoOficialUmAteAviao(terminal.piloto, terminal.oficialUm);       
            smartTwo.RetornarPilotoParaTerminal(aviao.piloto);
            var regraOficial = smartTwo.ValidarRegraOficial();

            Assert.AreEqual(true, regraOficial);
        }

        [Test]
        public void Deve_Validar_Regra_Comissaria()
        {
            var smartTwo = new SmartForTwo(terminal, aviao);

            smartTwo.TransportarChefePilotoAteAviao(terminal.piloto, terminal.chefeVoo);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);   
            smartTwo.TransportarChefeComissariaUmAteAviao(terminal.chefeVoo, terminal.comissariaUm);
            smartTwo.RetornarChefeParaTerminal(aviao.chefeVoo);
            var regraComissaria = smartTwo.ValidarRegraComissaria();

            Assert.AreEqual(true, regraComissaria);
        }
    }
}
