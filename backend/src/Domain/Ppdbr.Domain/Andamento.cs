namespace Ppdbr.Domain
{
    public class Andamento
    {
        protected Andamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public static readonly Andamento Intocado = new Andamento(0, "Não iniciado");
        public static readonly Andamento Iniciado = new Andamento(1, "Em Andamento");
        public static readonly Andamento Esgotado = new Andamento(2, "Esgotado");
        public static readonly Andamento Esquecido = new Andamento(3, "Esquecido");

        public int Codigo { get; private set; }
        public string Descricao { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj is Andamento andamento)
                return andamento.Codigo == Codigo;
            
            return false;
        }

        public override int  GetHashCode()
            => Codigo;
    }
}