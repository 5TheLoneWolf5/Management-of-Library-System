using System;
using System.Collections.Generic;

namespace Entidades {

  public class Biblioteca {

    public List<ItemBiblioteca> ItensBiblioteca = new List<ItemBiblioteca>(); 

    public void adicionarItem(ItemBiblioteca item) {
      ItensBiblioteca.Add(item);
    }

    public void removerItem(ItemBiblioteca item) {
      ItensBiblioteca.Remove(item);
    }

    public void exibirItens() {
      foreach (ItemBiblioteca i in ItensBiblioteca) {
        i.exibirInformacoes();
      }
    }

    public void realizarEmprestimo(ItemBiblioteca item, string data) {
      item.emprestar(data);
    }
    
  }
  
}