using System.Resources;
using System.Collections.Generic;
using System;

namespace Ppdbr.Domain
{
    public class Assunto
    {
        public Assunto(Titulo titulo, string resumo)
        {


            Titulo = titulo;
            Resumo = resumo;
            Posicao = Andamento.Intocado;
        }

	    public Titulo Titulo { get; private set; }
	    public string Resumo { get; private set; }
        public Andamento Posicao { get; private set; }
    }
}
