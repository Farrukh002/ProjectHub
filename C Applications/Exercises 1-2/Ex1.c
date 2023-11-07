#include <stdio.h>

int main() {
    int dividend, divisor;
    int quotient, remainder;

    // Input two integers
    printf("Enter the dividend: ");
    scanf("%d", &dividend);

    printf("Enter the divisor: ");
    scanf("%d", &divisor);

    // Calculate quotient and remainder
    quotient = dividend / divisor;
    remainder = dividend % divisor;

    // Print the results
    printf("Quotient: %d\n", quotient);
    printf("Remainder: %d\n", remainder);

    return 0;
}
