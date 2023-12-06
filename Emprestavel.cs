namespace Entidades {

  public interface Emprestavel {

    void verificarDisponibilidade(); // Public by default.
    string obterPrazoDeDevolucao();
    
  }
  
}