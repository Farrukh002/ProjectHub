#include <stdio.h>

int main() {
    // Input a number N
    int N;
    printf("Enter a number N: ");
    scanf("%d", &N);

    // Print NxN rectangle of stars
    for (int i = 1; i <= N; ++i) {
        for (int j = 1; j <= N; ++j) {
            printf("* ");
        }
        printf("\n");
    }

    return 0;
}