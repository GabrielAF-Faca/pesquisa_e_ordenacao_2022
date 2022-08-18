#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

//   ### PROTÓTIPO DAS FUNÇÕES ###

// VOID
void *sort_selection(int *vet, int tam);
void *sort_insertion(int *vet, int tam); 

//   #############################

void *sort_selection(int *vet, int tam) {

    int posMenor;

    for (int i = 0; i < tam-1; i++) {

        posMenor = i;

        for (int j = i + 1; j < tam && vet[j] < vet[posMenor]; j++) {

            posMenor = j;
       
        }

        if (i != posMenor) {

            int tmp = vet[i];
            vet[i] = vet[posMenor];
            vet[posMenor] = tmp;

        }
    }
}

void *sort_insertion(int *vet, int tam) {

    int tmp, j;

    for (int i = 1; i < tam; i++) {

        tmp = vet[i];

        for (j = i-1; j >= 0 && tmp < vet[j] ; j--) {

            vet[j + 1] = vet[j];

        }

        vet[j + 1] = tmp;

    }

}