using TestStack.BDDfy;
using Ppdbr.Domain;
using Shouldly;
using Xunit;

namespace Ppdbar.DomainTests
{

    [Story(
        Title="Guardar um novo assunto para conversar depois",
        AsA="usuário",
        IWant="Guardar meu novo assunto criado",
        SoThat="Possa relembrar quando desejar"
    )]
    public class GuardaUmNovoAssuntoParaConversarDepoisTest
    {
        Assunto assunto;
       
        [Fact(DisplayName="Dados um Assunto. Quando for um assunto valido Então deve enviar a base para gravação")]
        public void GravadoComSucesso()
        {

            this
            .Given(g => UmNovoAssunto())
            .When(g => g.TodosOsDadosEstaoPreenchidoCorretamente())
            .Then(x => x.DeveEnviarAoRepositorioParaGravacao())
            .BDDfy();
        }

         public void UmNovoAssunto()
          => assunto = new Assunto(new Titulo("Conveersa fiada"), "Falar sobre coisas aleatórioas");

        public void TodosOsDadosEstaoPreenchidoCorretamente()
        {
            var conversa = new Conversa();
            conversa.GuardarParaDepois(assunto);

        }
            
        
        public void DeveEnviarAoRepositorioParaGravacao()
            => andamento.ShouldBe(Andamento.Intocado);
    }
}