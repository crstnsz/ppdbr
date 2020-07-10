using System.Linq;
using EnsureThat;

public struct Titulo
{
    public Titulo(string titulo)
    {
        Ensure.That(titulo, "Título").IsNotEmptyOrWhiteSpace();
        Valor = new string(titulo.Take(200).ToArray());
  
    }
    
    public string Valor { get; private set; }

    public override string ToString()
        => Valor;
}