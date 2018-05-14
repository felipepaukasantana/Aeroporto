namespace CodeItAirlines.src
{
    public class Terminal 
    {
        public Motorista piloto { get; set; }
        public Pessoa oficialUm { get; set; }
        public Pessoa oficialDois { get; set; }
        public Motorista chefeVoo { get; set; }
        public Pessoa comissariaUm { get; set; }
        public Pessoa comissariaDois { get; set; }
        public Motorista policial { get; set; }
        public Pessoa presidiario { get; set; }

        public Terminal()
        {
            comissariaUm = new Comissaria();
            comissariaDois = new Comissaria();
            chefeVoo = new Chefe();
            oficialUm = new Oficial();
            oficialDois = new Oficial();
            piloto = new Piloto();
            policial = new Policial();
            presidiario = new Presidiario();
        }

    }
}
