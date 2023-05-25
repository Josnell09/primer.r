/*  Josnel tejeda
    Matricula: 2022-1145
    Clase: PPM
    pROFESOR: Carlos P. */

#include <stdio.h>
/* EstanciaEl programa, al recibir como dato la superficie de una estancia expresada➥en acres, la convierte a hectáreas.ECA: variable de tipo real. */
void main(void)
{
    float ECA;
    printf("Ingrese la extensión de la estancia:");
    scanf("%f", &ECA);ECA = ECA * 4047 / 10000;
    printf("\nExtensión de la estancia en hectáreas: %5.2f", ECA);
}
