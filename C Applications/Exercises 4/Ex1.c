#include <stdio.h>

int main() {
    int num, power = 1;

    // Input a number
    printf("Enter a number: ");
    scanf("%d", &num);

    printf("Powers of 2 up to %d: ", num);

    // Print powers of 2 up to the input number
    while (power <= num) {
        printf("%d", power);

        // Check if the next power of 2 is within the limit
        if (power * 2 <= num) {
            printf(", ");
        } else {
            printf("\n");
        }

        // Calculate the next power of 2
        power *= 2;
    }

    return 0;
}
