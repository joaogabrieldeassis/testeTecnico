
using MyApp;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class Lizard : ILizard
    {
        
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor)
        {
            if (valor.ToLower().Equals("pedra") || valor.ToLower().Equals("tesoura"))
                return false;

            return true;
        }        
    }
}
