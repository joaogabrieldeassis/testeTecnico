namespace TesteProcesso.Interfaces
{
    public interface IJokenpo<T> where T : class
    {
        public bool AhJogadaDoJogadorUmEhMaisForteQueAhDoJogadorDois(string valor);
    }
}
