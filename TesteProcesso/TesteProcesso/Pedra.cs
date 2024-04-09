
using MyApp;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class Pedra : IPedra
    {
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor)
        {
            if (valor.ToLower().Equals("spock") || valor.ToLower().Equals("papel"))
                return false;

            return true;
        }        
    }
}
