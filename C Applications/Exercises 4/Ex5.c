#include <stdio.h>

int main() {
    int N, count = 0;

    // Input a number N
    printf("Enter a number N: ");
    scanf("%d", &N);

    // Print divisors of N and count the number of divisors
    printf("Divisors: ");
    for (int i = 1; i <= N; ++i) {
        if (N % i == 0) {
            printf("%d", i);

            // Print a comma if there are more divisors to come
            if (i != N) {
                printf(",");
            }

            // Increment the count of divisors
            ++count;
        }
    }

    // Print the number of divisors
    printf("\nNumber of divisors: %d\n", count);

    return 0;
}
