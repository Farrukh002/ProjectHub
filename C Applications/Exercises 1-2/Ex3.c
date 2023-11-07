#include <stdio.h>
#include <math.h>

int main() {
    int num1, num2, num3, num4;
    double average, deviation1, deviation2, deviation3, deviation4;

    // Input four integers
    printf("Enter the first integer: ");
    scanf("%d", &num1);

    printf("Enter the second integer: ");
    scanf("%d", &num2);

    printf("Enter the third integer: ");
    scanf("%d", &num3);

    printf("Enter the fourth integer: ");
    scanf("%d", &num4);

    // Calculate the average
    average = (num1 + num2 + num3 + num4) / 4.0;

    // Calculate the deviation from average for each input
    deviation1 = num1 - average;
    deviation2 = num2 - average;
    deviation3 = num3 - average;
    deviation4 = num4 - average;

    // Print the average
    printf("Average: %.2lf\n", average);

    // Print the deviation for each input
    printf("Deviation from average for the first integer: %.2lf\n", deviation1);
    printf("Deviation from average for the second integer: %.2lf\n", deviation2);
    printf("Deviation from average for the third integer: %.2lf\n", deviation3);
    printf("Deviation from average for the fourth integer: %.2lf\n", deviation4);

    return 0;
}
