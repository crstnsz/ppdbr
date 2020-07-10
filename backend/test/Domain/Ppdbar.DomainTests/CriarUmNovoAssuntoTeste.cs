using TestStack.BDDfy;
using Ppdbr.Domain;
using Shouldly;
using Xunit;

namespace Ppdbar.DomainTests
{

    [Story(
        Title = "Criar um novo assunto",
        AsA = "usuário",
        IWant = "Criar assuntos diversos",
        SoThat = "Não faltar assuntos e controlar o que já foi comendado e o que não foi"
    )]
    public class CriarUmNovoAssunto
    {
        Assunto assunto;
        Andamento andamento;

        [Fact(DisplayName = "Dados um Assunto. Quando eu crio. Então a posição do andamento deve ser Intocado")]
        public void CriarUmNovoAssuntoIntocado()
        {

            this
            .Given(g => UmNovoAssunto())
            .When(g => g.QuandoVerificarAPosicaoDoAndamento())
            .Then(x => x.SeuValorEstaComoIntocada())
            .BDDfy();
        }

        public void UmNovoAssunto()
         => assunto = new Assunto(new Titulo("Conveersa fiada"), "Falar sobre coisas aleatórioas");

        public void QuandoVerificarAPosicaoDoAndamento()
            => andamento = assunto.Posicao;

        public void SeuValorEstaComoIntocada()
            => andamento.ShouldBe(Andamento.Intocado);
    }
}