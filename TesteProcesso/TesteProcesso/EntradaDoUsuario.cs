using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteProcesso.Interfaces;

namespace TesteProcesso
{
    public class EntradaDoUsuario : IEntradaDoUsuario
    {
        public readonly IPapel _papel;
        private readonly IPedra _pedra;
        private readonly ILizard _lizard;
        private readonly Ispock _spock;
        private readonly ITesoura _tesoura;

        public EntradaDoUsuario(IPapel papel, IPedra pedra, ILizard lizard, Ispock spock, ITesoura tesoura)
        {
            _papel = papel;
            _pedra = pedra;
            _lizard = lizard;
            _spock = spock;
            _tesoura = tesoura;
        }

        public void ReceberAhEntradaDoUsuario()
        {
            Console.WriteLine("Jogador 1");
            var entradaDoJogadorUm = Console.ReadLine();
            Console.WriteLine("Jogador 2 ");
            var entradaDoJogadorDois = Console.ReadLine();

            OrquestrarOhSistema(entradaDoJogadorUm, entradaDoJogadorDois);
        }

        public void OrquestrarOhSistema(string valorDoJogadorUm, string valorDoJogadorDois)
        {
            switch (valorDoJogadorUm)
            {
                case "papel":
                    OrquestrarAhEntradaDoUsuario(_papel.AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(valorDoJogadorDois));
                    break;
                case "pedra":
                    OrquestrarAhEntradaDoUsuario(_pedra.AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(valorDoJogadorDois));
                    break;
                case "lizard":
                    OrquestrarAhEntradaDoUsuario(_lizard.AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(valorDoJogadorDois));
                    break;
                case "spock":
                    OrquestrarAhEntradaDoUsuario(_spock.AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(valorDoJogadorDois));
                    break;
                case "tesoura":
                    OrquestrarAhEntradaDoUsuario(_tesoura.AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(valorDoJogadorDois));
                    break;
            }
        }

        public void OrquestrarAhEntradaDoUsuario(bool jogadorUmGanhou)
        {
            Console.WriteLine();
            Console.WriteLine();
            if (jogadorUmGanhou)
                Console.WriteLine($"Jogador 1 ganhou");
            else
                Console.WriteLine($"Jogador 2 ganhou");

            Console.WriteLine();
            Console.WriteLine("Deseja jogar novamente?\n 1 - sim\n2 - não");
            int numeroParaJogarNovamente = Convert.ToInt32(Console.ReadLine());

            if (numeroParaJogarNovamente == 1)
                Program.Main();
            else
                Console.WriteLine("Fim do programa");
        }
    }
}
