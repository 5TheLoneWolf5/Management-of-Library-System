using System;

namespace Entidades  {

  public class Revista : ItemBiblioteca, Emprestavel {

    public Revista (string titulo, string autor, int anoPublicacao) : base(titulo, autor, anoPublicacao) {

    }
    
    public override void emprestar(string data) {
      Console.WriteLine($"Emprestando a revista: {Titulo}.");
      emprestado = true;
      this.Data = data;
    }

    public override void devolver() {
      Console.WriteLine($"Devolvendo a revista: {Titulo}.");
      this.Data = "Não há data.";
    }

    public override void exibirInformacoes() {
      Console.WriteLine($"\nTítulo: {Titulo};\nAutor: {Autor};\nAno de Publicação: {AnoPublicacao}.");
    }

    public void verificarDisponibilidade() {
      if (emprestado)
        Console.WriteLine("Revista disponível.");
      else
        Console.WriteLine("Revista não disponível.");
    }

    public string obterPrazoDeDevolucao() {
      return "Prazo de devolução da revista: " + this.Data + ".";
    }

  }

}