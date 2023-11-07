#include <stdio.h>

int main() {
    int N;

    // Input a number N
    printf("Enter a number N: ");
    scanf("%d", &N);

    // Print a triangle of stars with height N
    for (int i = 1; i <= N; ++i) {
        // Print i stars in the current row
        for (int j = 1; j <= i; ++j) {
            printf("*");
        }
        // Move to the next line after printing stars in the current row
        printf("\n");
    }

    return 0;
}
