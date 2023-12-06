using System;

namespace Entidades {

  public class Livro : ItemBiblioteca, Emprestavel {

    public Livro (string titulo, string autor, int anoPublicacao) : base(titulo, autor, anoPublicacao) {
      
    }
    
    public override void emprestar(string data) {
      Console.WriteLine($"Emprestando o livro: {Titulo}.");
      emprestado = true;
      this.Data = data;
    }
    
    public override void devolver() {
      Console.WriteLine($"Devolvendo o livro: {Titulo}.");
      emprestado = false;
      this.Data = "Não há data.";
    }
    
    public override void exibirInformacoes() {
      Console.WriteLine($"\nTítulo: {Titulo};\nAutor: {Autor};\nAno de Publicação: {AnoPublicacao}.");
    }

    public void verificarDisponibilidade() {
      if (emprestado)
        Console.WriteLine("Livro não disponível.");
      else
        Console.WriteLine("Livro disponível.");
    }
    
    public string obterPrazoDeDevolucao() {
      return "Prazo de devolução do livro: " + this.Data + ".";
    }
    
  }
  
}