#include <stdio.h>
#include <math.h>
#define PI 3.14159265359

int main() {
    int radius;
    double volume, surfaceArea;

    printf("Enter the radius of sphere: ");
    scanf("%d", &radius);

    volume = (4.0 / 3.0) * PI * pow(radius, 3);
    surfaceArea = 4.0 * PI * pow(radius, 2);

    printf("Volume result: %lf\n", volume);
    printf("Surface area result: %lf\n", surfaceArea);

    return 0;
}
