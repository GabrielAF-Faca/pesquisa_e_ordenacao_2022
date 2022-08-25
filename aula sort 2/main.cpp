#include <iostream>
#include <cstdlib>
#include <locale>

#include "../metodos.h"

using namespace std;

#define TAM 500

int main(){
    setlocale(LC_ALL, "Portuguese");


    int vet[TAM];

    fill_vet(vet, TAM);
    
    cout << "Antes do sort" << endl;
    show_vet(vet, TAM);
    cout << "################" << endl;

    cout << endl << endl;

    sort_comb(vet, TAM);

    cout << endl << "Fim do sort\n\n\n";
    show_vet(vet, TAM);

    return 1;

}