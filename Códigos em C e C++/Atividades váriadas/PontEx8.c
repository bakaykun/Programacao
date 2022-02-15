#include <stdio.h>
#include <stdlib.h>

int tricci(int n) {
	if(n == 0 || n == 1) {
		return 0;
	}
	if(n == 2) {
		return 1;

	}
	return tricci(n - 1) + tricci(n - 2) + tricci(n - 3);
}
int main(){

    int n;

    printf("digite um numero:");
    scanf("%d", &n);

    printf("o numero %d e: %d",n, tricci(n));

    return 0;

}