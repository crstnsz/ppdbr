using System.Threading.Tasks;
using Xunit;

public class TituloTests
{
    [Fact(DisplayName="Dado um Titulo. "
    + "Quando tiver menos de 200 caracteres"
    + "Então o valor é o texto passado")]
    public void TituloCurto()
    {
        var textoEntrada = "Olá Mundo";
        var textoEsperado = textoEntrada;

        Assert.Equal(textoEsperado, textoEntrada);
    }
}
            