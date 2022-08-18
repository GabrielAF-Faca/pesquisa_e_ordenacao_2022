#include <iostream>
#include <cstdlib>
#include <locale>

#include "../metodos.h"

using namespace std;

#define TAM 6

int main(){
    setlocale(LC_ALL, "Portuguese");
    
    int vet[TAM];

    fill_vet(vet, TAM);
    
    show_vet(vet, TAM);

    

    return 1;

}