#include <stdio.h>

int main() {
    int N;

    // Input a number N
    printf("Enter a number N: ");
    scanf("%d", &N);

    // Print numbers <= N that are divisible by 3
    printf("Numbers less than or equal to %d that can be divided by 3: ", N);

    for (int i = 0; i <= N; ++i) {
        if (i % 3 == 0) {
            printf("%d", i);

            // Print a comma if the next number is also divisible by 3 and not the last number
            if (i + 3 <= N) {
                printf(",");
            }
        }
    }

    printf("\n");

    return 0;
}
