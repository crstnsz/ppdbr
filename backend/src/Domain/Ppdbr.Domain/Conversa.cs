
using Ppdbr.Domain.Repository;


namespace Ppdbr.Domain
{
    public class Conversa
    {
        public readonly IAssuntoRepository _assuntoRepository;

        public Conversa(IAssuntoRepository assuntoRepository)
        {
            _assuntoRepository = assuntoRepository;
        }

        public void GuardarParaDepois(Assunto assunto)
        {

        }
        
    }    
}

