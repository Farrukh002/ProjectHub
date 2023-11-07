#include <stdio.h>

int main() {
    int number;

    printf("Enter an interger: ");
    scanf("%d", &number);

    int rightmostDigit = number % 10;
    printf("The rightmost digit is: %d\n", rightmostDigit);

    return 0;
}