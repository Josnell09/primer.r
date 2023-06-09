/*josnell tejeda  */

#include <stdio.h>



const int TAM = 3;



void Lectura(int[][TAM], int);
void SumarMatrices(int[][TAM], int[][TAM], int[][TAM], int);
void Imprimir(int[][TAM], int);

int main(void)
{
    int MAT1[TAM][TAM];
    int MAT2[TAM][TAM];
    int resultado[TAM][TAM];


    printf("Ingrese los elementos de la primera matriz:\n");
    Lectura(MAT1, TAM);


    printf("\nIngrese los elementos de la segunda matriz:\n");
    Lectura(MAT2, TAM);


    SumarMatrices(MAT1, MAT2, resultado, TAM);


    printf("\nResultado de la suma:\n");
    Imprimir(resultado, TAM);



    return 0;
}

void Lectura(int A[][TAM], int F)
{
    int I, J;
    for (I = 0; I < F; I++)
    {
        for (J = 0; J < F; J++)
        {
            printf("Ingrese el elemento %d %d: ", I + 1, J + 1);
            scanf("%d", &A[I][J]);
        }
    }
}
void SumarMatrices(int A[][TAM], int B[][TAM], int resultado[][TAM], int F)
{
    int I, J;
    for (I = 0; I < F; I++)
    {
        for (J = 0; J < F; J++)
        {
            resultado[I][J] = A[I][J] + B[I][J];
        }
    }
}
void Imprimir(int A[][TAM], int F)
{
    int I, J;
    for (I = 0; I < F; I++)
    {
        for (J = 0; J < TAM; J++)
        {
            printf("%d ", A[I][J]);
        }
        printf("\n");
    }
}

