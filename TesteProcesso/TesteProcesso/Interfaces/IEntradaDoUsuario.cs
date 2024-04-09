using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProcesso.Interfaces
{
    public interface IEntradaDoUsuario
    {
        public void ReceberAhEntradaDoUsuario();
        public void OrquestrarOhSistema(string valorDoJogadorUm, string valorDoJogadorDois);
    }
}
