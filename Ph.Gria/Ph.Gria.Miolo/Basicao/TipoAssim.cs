using System.ComponentModel;

namespace Ph.Gria.Miolo.Basicao
{
    /// <summary>
    /// Camaradas pé de chinelo suportados por nossa linguagem.
    /// </summary>
    public enum TipoAssim
    {
        [Description("Representação do tipo 'string'")]
        Mimimi = 0,
        [Description("Representação do tipo 'array'")]
        Trem = 1,
        [Description("Representação do tipo 'bool'")]
        Bão = 2,
        [Description("Representação do tipo 'int'")]
        Pingado = 3,
        [Description("Representação do tipo 'double'")]
        Dose = 4,
        [Description("Representação do tipo 'decimal'")]
        Conto = 5
    }
}
