using System;
using Ppdbr.Domain;
using Xunit;
using Shouldly;
using TestStack.BDDfy;

namespace Ppdbar.DomainTests
{
    public class AndamentoTest
    {
        [Fact]
        public void AndamentosIguais()
        {
            
            var andamento = Andamento.Intocado;

            andamento.ShouldBe(Andamento.Intocado);
            andamento.ShouldNotBe(Andamento.Iniciado);
            andamento.ShouldNotBe(Andamento.Esgotado);
            (andamento == Andamento.Intocado).ShouldBeTrue();
            (andamento == Andamento.Esgotado).ShouldBeFalse();

            (andamento != Andamento.Intocado).ShouldBeFalse();
            (andamento != Andamento.Iniciado).ShouldBeTrue();

        }
    }
}
