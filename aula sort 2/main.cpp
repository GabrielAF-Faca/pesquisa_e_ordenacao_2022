#include <iostream>
#include <cstdlib>
#include <locale>

#include "../metodos.h"

using namespace std;

int main(){
    setlocale(LC_ALL, "Portuguese");
    
    int vet[5] = {5, 2, 3, 1, 4};

    sort_selection(vet, sizeof(vet)/sizeof(int));
    
    for (int i = 0; i < 5; i++) {

        cout << "[" << vet[i] << "] ";

    }

    return 1;

}