/*  Josnel tejeda
    Matricula: 2022-1145
    Clase: PPM
    pROFESOR: Carlos P. */

#include <stdio.h>
void main(void)
{
    float PIE, LIB, MET, KIL;
    printf("Ingrese los datos del objeto: ");
    scanf("%f  %f", &PIE, &LIB);
    MET = PIE * 0.09290;
    KIL = LIB * 0.45359;
    printf("\nDatos del objeto \nLongitud: %5.2f  \t Peso: %5.2f", MET, KIL);

}
