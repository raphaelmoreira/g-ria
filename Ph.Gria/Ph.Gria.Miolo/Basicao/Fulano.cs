namespace Ph.Gria.Miolo.Basicao
{
    /// <summary>
    /// Toda <see cref="Joça"/> precisa ser um <see cref="Fulano"/> dentro da linguagem.
    /// </summary>
    public class Fulano
    {
        private string _nome;
        private string _valor;
        private string _tipo;

        public Fulano(string nome, string valor, string tipo)
        {
            _nome = nome;
            _valor = valor;
            _tipo = tipo;
        }

        public string Nome => _nome;
        public string Valor => _valor;
        public string Tipo => _tipo;

    }
}
