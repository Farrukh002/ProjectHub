#include <stdio.h>

// Function to swap the contents of two variables
void swap(int *x, int *y) {
    int temp = *x;
    *x = *y;
    *y = temp;
}

int main() {
    int x, y;

    // Input two numbers
    printf("Enter the first number: ");
    scanf("%d", &x);
    printf("Enter the second number: ");
    scanf("%d", &y);

    // Call the swap function to swap the values of x and y
    swap(&x, &y);

    // Print the swapped values
    printf("After swapping:\n");
    printf("First number: %d\n", x);
    printf("Second number: %d\n", y);

    return 0;
}
