#include <stdio.h>
#include <stdlib.h>
#include <math.h>
/* Serie de ULAM.El programa, al recibir como dato un entero positivo, obtiene
 y escribe➥la serie de ULAM.NUM: variable de tipo entero. */
voidmain(void)
{
    intNUM;
    printf(“Ingresa el número para calcular la serie: “);
    scanf(“%d”, &NUM);
    if(NUM > 0)
    {
        printf(“\nSerie de ULAM\n”);
        printf(“%d \t”, NUM);
        while(NUM != 1)
        {
            if(pow(-1, NUM) > 0)NUM = NUM / 2;
            elseNUM = NUM * 3 + 1;
            printf(“%d \t”, NUM);
        }
    }
    elseprintf(“\n NUM debe ser un entero positivo”);
}
