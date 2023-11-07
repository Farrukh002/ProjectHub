#include <stdio.h>

int main() {
    int num, sum = 0, i;

    // Input a number
    printf("Enter a number: ");
    scanf("%d", &num);

    // Calculate the cumulative sum
    for (i = 1; i <= num; ++i) {
        sum += i;
    }

    // Print the cumulative sum
    printf("Cumulative sum from 1 to %d = ", num);

    // Print the individual numbers and the final sum
    for (i = 1; i <= num; ++i) {
        printf("%d", i);

        if (i < num) {
            printf("+");
        } else {
            printf("=");
        }
    }

    printf("%d\n", sum);

    return 0;
}
