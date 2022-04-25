namespace Ph.Gria.Miolo.Basicao
{
    /// <summary>
    /// Essa joça é responsável por armazenar e validar cada joça dessa linguagem, a fim de auxiliar o desenvolvedor quando estiver codando.
    /// </summary>
    public abstract class Joça
    {
        public int Linha { get; set; }

        private string _texto;

        public string Texto
        {
            get { return _texto; }
        }

    }
}
