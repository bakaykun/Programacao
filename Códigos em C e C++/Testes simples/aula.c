#include <stdio.h>

#include <stdlib.h>

int main()

{

  float a;

  float *p, *q;

  a = 3.14;

  printf("%f\n", a);

  p = &a;

  *p = 2.718;

  printf("%f\n", a);

  a = 5;

  printf("%f\n", *p);

  p = NULL;

  p = (float *) malloc(sizeof(float));

  *p = 20;

  q = p;

  printf("%f\n", *p);

  printf("%f\n", *q);

}