#include <iostream>
#include <string>
#include <cstdlib>
#include <time.h>

using namespace std;

//   ### PROTÓTIPO DAS FUNÇÕES ###

// VOID
void fill_vet(int *vet, int tam);

void show_vet(int *vet, int tam);

void sort_selection(int *vet, int tam);
void sort_insertion(int *vet, int tam);

void sort_comb(int *vet, int tam);

//   #############################

void sort_selection(int *vet, int tam) {

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

void sort_insertion(int *vet, int tam) {

    int tmp, j;

    for (int i = 1; i < tam; i++) {

        tmp = vet[i];

        for (j = i-1; j >= 0 && tmp < vet[j] ; j--) {

            vet[j + 1] = vet[j];

        }

        vet[j + 1] = tmp;

    }

}

void sort_comb(int *vet, int tam) {

    int dist = tam;
    bool houve_troca = true;

    do {
        dist = (int) dist/1.3;

        if (dist < 1) dist = 1;

        houve_troca = false;

        for (int i = 0; i+dist < tam; i++) {

            if (vet[i] > vet[i+dist]) {

                int aux = vet[i];
                vet[i] = vet[i+dist];
                vet[i+dist] = aux;

                houve_troca = true;

            }

        }

        //show_vet(vet, tam);

    } while(dist > 1 || houve_troca);


}

void show_vet(int *vet, int tam) {

    for (int i = 0; i < tam; i++) {

        cout << "[" << vet[i] << "] ";

    }

    cout << endl;

}

void fill_vet(int *vet, int tam) {

    srand((unsigned)time(0));

    for (int i = 0; i < tam; i++) {

        vet[i] = rand()%100;

    }

}
