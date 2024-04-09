
using MyApp;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class Papel : IPapel
    {
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor)
        {
            if (valor.ToLower().Equals("tesoura") || valor.ToLower().Equals("lizard"))
                return false;

            return true;
        }
    }
}
