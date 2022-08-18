#include <iostream>
#include <cstdlib>
#include <locale>

using namespace std;

int *selection_sort(int *vet);

int main(){
    setlocale(LC_ALL, "Portuguese");
    
    
    

    return 1;
}

int *selection_sort(int *vet) {

     int i, j, tmp, posMenor;

    int tam = sizeof(vet);

    for (i = 0; i < tam-1; i++)
    {

        posMenor = i;

        for (j = i + 1; j < tam; j++)
        {

            if (vet[j] < vet[posMenor]) {

                posMenor = j;

            }

        }

        if (i != posMenor)
        {
            
            tmp = vet[i];
            vet[i] = vet[posMenor];
            vet[posMenor] = tmp;

        }


    }

}