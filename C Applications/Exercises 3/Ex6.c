#include <stdio.h>
#include <math.h>

// Function to calculate the third side and area of the right triangle
void calculateTriangleProperties(double a, double b, double *c, double *area) {
    // Calculate the length of the third side using Pythagorean theorem
    *c = sqrt(a * a + b * b);

    // Calculate the area of the right triangle
    *area = 0.5 * a * b;
}

int main() {
    double a, b, c, area;

    // Input the sides of the right triangle
    printf("Enter the length of side a: ");
    scanf("%lf", &a);
    printf("Enter the length of side b: ");
    scanf("%lf", &b);

    // Call the function to calculate the third side and area
    calculateTriangleProperties(a, b, &c, &area);

    // Print the results
    printf("Length of the third side (hypotenuse): %.2lf meters\n", c);
    printf("Area of the right triangle: %.2lf square meters\n", area);

    return 0;
}
