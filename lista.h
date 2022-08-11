#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

typedef struct no {
    int dado;
    struct no *prox;
}Lista;

//   ### PROTÓTIPO DAS FUNÇÕES ###

// LISTA
Lista *lista_inserir(int valor, Lista *lista);
Lista *lista_excluir(int valor, Lista *lista);
Lista *lista_excluir_todos(int valor, Lista *lista);
Lista *lista_podar(Lista *lista);

// BOOL
bool lista_encontrar(int valor, Lista *lista);

// INT
int lista_contar(Lista *lista);

// VOID
void lista_exibir(Lista *lista, int break_line = 0);

//   #############################


Lista *lista_inserir(int valor, Lista *lista){
    Lista *novo, *p, *pR;
    
    //alocar mem�ria
    novo = (Lista *)malloc(sizeof(Lista));
    
    //depositar valor
    novo->dado = valor;
    novo->prox = NULL;

    //testar se � primeira vez
    if (!lista) return novo;

    //localizar posi��o de inser��o
    for (pR = NULL, p = lista; p; pR = p, p = p->prox){
        if (valor < p->dado){
            break;
        }
    }

    //"engatar"

    if (p == lista){
        //testar se no in�cio
        novo->prox = lista;
        return novo;
    }else if (!p){
        //testar se no fim
        pR->prox = novo;
    }else{
       pR->prox = novo;
       novo->prox = p;  
    }

    //retornar o in�cio da lista
    return lista;
}

bool lista_encontrar(int valor, Lista *lista){
  if (!lista) {
    cout << "Lista vazia. Operação cancelada!" << endl;
    return false;
  }

  Lista *p;

  for (p = lista; p; p = p->prox) {
    if (valor == p->dado) {
      return true;
    }
  }

  return false;
  
}

Lista *lista_excluir(int valor, Lista *lista) {
  if (!lista) {
    cout << "Lista vazia. Operação cancelada!" << endl;
    return lista;
  }

  Lista *p, *pR;

  for (pR = NULL, p = lista; p; pR = p, p = p->prox) {
    if (valor == p->dado) {
      //eh o primeiro
      if (p == lista) {
        lista = lista->prox;
      } else if (!p->prox) { //eh o ultimo
        pR->prox = NULL;
      } else { //esta entre Listas
        pR->prox = p->prox;
      }
      free(p);
      return lista;
    }
  }
  cout << "Valor não localizado para exclusão!" << endl;
  return lista;
}

Lista *lista_excluir_todos(int valor, Lista *lista){
  if(!lista){
    cout << "Lista vazia. Operação cancelada!" << endl;
    return lista;
  }

  while(lista_encontrar(valor, lista)){
    
    lista = lista_excluir(valor, lista);

  }

  return lista;

}

void lista_exibir(Lista *lista, int break_line = 0){
  if (!lista){ 
      cout << "Lista vazia\n";
      return;
  }

  Lista *p;

  for (p = lista; p ; p = p->prox){
      cout << "[" << p->dado << "] " << ((break_line != 0) ? "\n" : "");
  }

}

int lista_contar(Lista *lista){
  if (!lista){ 
      cout << "Lista vazia\n";
      return 0;
  }

  Lista *p;
  int contador = 0;

  for (p = lista; p ; p = p->prox){
      contador++;
  }

  return contador;
}

Lista *lista_podar(Lista *lista){
  if (!lista){
    cout << "Lista vazia\n";
    return 0;
  }
}