using System.Collections.Generic;

namespace CodeItAirlines.src
{
    public class SmartForTwo 
    {
        public List<Terminal> terminal;
        public List<Aviao> aviao;

        public SmartForTwo(Terminal terminal, Aviao aviao)
        {
            this.terminal = new List<Terminal>();
            this.terminal.Add(terminal);

            this.aviao = new List<Aviao>();
            this.aviao.Add(aviao);
        } 

        public void TransportarChefePilotoAteAviao(Motorista motorista, Motorista passageiro)
        {
            aviao.ForEach(x => x.chefeVoo = passageiro);
            aviao.ForEach(x => x.piloto = motorista);
            terminal.ForEach(x => x.chefeVoo = null);
            terminal.ForEach(x => x.piloto = null);
        }

        public void TransportarPilotoOficialUmAteAviao(Motorista motorista, Pessoa passageiro)
        {
            aviao.ForEach(x => x.oficialUm = passageiro);
            aviao.ForEach(x => x.piloto = motorista);
            terminal.ForEach(x => x.oficialUm = null);
            terminal.ForEach(x => x.piloto = null);
        }

        public void TransportarPilotoOficialDoisAteAviao(Motorista motorista, Pessoa passageiro)
        {
            aviao.ForEach(x => x.oficialDois = passageiro);
            aviao.ForEach(x => x.piloto = motorista);
            terminal.ForEach(x => x.oficialDois = null);
            terminal.ForEach(x => x.piloto = null);
        }

        public void TransportarChefeComissariaUmAteAviao(Motorista motorista, Pessoa passageiro)
        {
            aviao.ForEach(x => x.comissariaUm = passageiro);
            aviao.ForEach(x => x.chefeVoo = motorista);
            terminal.ForEach(x => x.comissariaUm = null);
            terminal.ForEach(x => x.chefeVoo = null);
        }

        public void TransportarChefeComissariaDoisAteAviao(Motorista motorista, Pessoa passageiro)
        {
            aviao.ForEach(x => x.comissariaDois = passageiro);
            aviao.ForEach(x => x.chefeVoo = motorista);
            terminal.ForEach(x => x.comissariaDois = null);
            terminal.ForEach(x => x.chefeVoo = null);
        }

        public void RetornarPilotoParaTerminal(Motorista motorista)
        {
            terminal.ForEach(x => x.piloto = motorista);
            aviao.ForEach(x => x.piloto = null);
        }

        public void RetornarChefeParaTerminal(Motorista motorista)
        {
            terminal.ForEach(x => x.chefeVoo = motorista);
            aviao.ForEach(x => x.chefeVoo = null);
        }

        public bool ValidarRegraOficial()
        {
            return terminal.Exists(x => x.chefeVoo != null && 
                   (x.oficialDois != null || x.oficialUm != null) &&
                   (x.piloto == null && x.comissariaDois == null && x.comissariaUm == null)) ||
                   aviao.Exists(x => x.chefeVoo != null &&
                   (x.oficialDois != null || x.oficialUm != null) &&
                   (x.piloto == null && x.comissariaDois == null && x.comissariaUm == null));
        }  
                
        public bool ValidarRegraComissaria()
        {
            return terminal.Exists(x => x.piloto != null &&
                   (x.comissariaUm != null || x.comissariaDois != null) &&
                   (x.chefeVoo == null && x.oficialUm == null && x.oficialDois == null)) ||
                   aviao.Exists(x => x.piloto != null &&
                   (x.comissariaUm != null || x.comissariaDois != null) &&
                   (x.chefeVoo == null && x.oficialUm == null && x.oficialDois == null));
        }

        public bool ValidarRegraPresidiario() 
        {
            return terminal.Exists(x => x.policial == null && 
                   (x.presidiario != null && 
                   (x.piloto == null && x.chefeVoo == null && x.comissariaDois == null && x.comissariaUm == null && x.oficialUm == null && x.oficialDois == null))) ||
                   aviao.Exists(x => x.policial == null &&
                   (x.presidiario != null &&
                   (x.piloto == null && x.chefeVoo == null && x.comissariaDois == null && x.comissariaUm == null && x.oficialUm == null && x.oficialDois == null)));
        }

        public bool ValidarTerminalTemPessoas()
        {
            return terminal.Exists(x => x.policial != null && x.presidiario != null && x.chefeVoo != null && x.comissariaDois != null && x.comissariaUm != null && x.oficialUm != null && x.oficialDois != null);
        }
        
        public void TransportarChefePolicialAteAviao(Motorista motorista, Motorista passageiro)
        {
            aviao.ForEach(x => x.chefeVoo = passageiro);
            aviao.ForEach(x => x.policial = motorista);
            terminal.ForEach(x => x.chefeVoo = null);
            terminal.ForEach(x => x.policial = null);
        }

        public void TransportarPolicialPresidiarioAteAviao(Motorista motorista, Pessoa passageiro)
        {
            aviao.ForEach(x => x.presidiario = passageiro);
            aviao.ForEach(x => x.policial = motorista);
            terminal.ForEach(x => x.presidiario = null);
            terminal.ForEach(x => x.policial = null);
        }

        public void RetornarPolicialParaTerminal(Motorista motorista)
        {
            terminal.ForEach(x => x.policial = motorista);
            aviao.ForEach(x => x.policial = null);
        }

    }
}
