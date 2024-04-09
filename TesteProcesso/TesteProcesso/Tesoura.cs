
using MyApp;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class Tesoura : ITesoura
    {
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor)
        {
            if (valor.ToLower().Equals("spock") || valor.ToLower().Equals("pedra"))
                return false;

            return true;
        }       
    }
}
