using System;
using Entidades;

class Program {
  
  public static void Main (string[] args) {

    Livro livro = new Livro("Dom Casmurro", "Machado de Assis", 1899);
    Livro livroDois = new Livro("Les Misérables", "Victor Hugo", 1862);
    Revista revista = new Revista("Revista Times Edição 12", "Adam Stones", 1980);
    Revista revistaDois = new Revista("Revista BCD Edição 43", "Mark Waters", 1998);

    Biblioteca biblioteca = new Biblioteca();
    
    biblioteca.adicionarItem(livro);
    biblioteca.adicionarItem(revista);
    biblioteca.adicionarItem(livroDois);
    biblioteca.adicionarItem(revistaDois);

    biblioteca.realizarEmprestimo(biblioteca.ItensBiblioteca[0], "04/12/2006");
    livro.verificarDisponibilidade(); // Only by calling object directly one can use the interface methods.
    Console.WriteLine(livro.obterPrazoDeDevolucao());
    biblioteca.ItensBiblioteca[0].devolver();
    livro.verificarDisponibilidade();

    // I can use the implemented overridden methods used in the the subclass, even if the object type belongs to the superclass (which has the abstract methods, but not the implemented ones). This is not true for the interface's implementation or other methods, though.
    // var testing = (Livro)biblioteca.ItensBiblioteca[0].verificarDisponibilidade();
    
    biblioteca.removerItem(livroDois);

    biblioteca.exibirItens();

    Console.ReadLine();
    
  }
}