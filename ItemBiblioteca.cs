namespace Entidades {
  
  public abstract class ItemBiblioteca {

    private string titulo;
    private string autor;
    private int anoPublicacao;
    
    // Personalized fields:
    protected bool emprestado = false;
    private string data;

    public string Titulo {
      get { return this.titulo; }
      set { this.titulo = value; }
    }
    
    public string Autor {
      get { return this.autor; }
      set { this.autor = value; }
    }
    
    public int AnoPublicacao {
      get { return this.anoPublicacao; }
      set { this.anoPublicacao = value; }
    }

    public string Data {
      get { return this.data; }
      set { this.data = value; }
    }

    public ItemBiblioteca(string titulo, string autor, int anoPublicacao) {
      this.titulo = titulo;
      this.autor = autor;
      this.anoPublicacao = anoPublicacao;
    }

    public abstract void emprestar(string data);
    public abstract void devolver();
    public abstract void exibirInformacoes();
    
  }
  
}