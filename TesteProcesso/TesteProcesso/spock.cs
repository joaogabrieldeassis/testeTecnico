
using MyApp;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class spock : Ispock
    {
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor)
        {
            if (valor.ToLower().Equals("lizard") || valor.ToLower().Equals("papel"))
                return false;

            return true;
        }        
    }
}
