#include <stdio.h>
#include <math.h>

// Function to convert distance from km to miles
double convertKmToMiles(double km) {
    return km * 0.621371; // 1 kilometer = 0.621371 miles
}

// Function to convert angle from degrees to radians
double convertDegToRad(double deg) {
    return deg * (M_PI / 180.0); // 1 degree = pi/180 radians
}

int main() {
    double distanceKm, angleDeg, distanceMiles, angleRadians;

    // Input distance in kilometers and angle in degrees
    printf("Enter distance in kilometers: ");
    scanf("%lf", &distanceKm);

    printf("Enter angle in degrees: ");
    scanf("%lf", &angleDeg);

    // Convert distance from km to miles using the function
    distanceMiles = convertKmToMiles(distanceKm);

    // Convert angle from degrees to radians using the function
    angleRadians = convertDegToRad(angleDeg);

    // Print the results
    printf("Distance in miles: %.2f\n", distanceMiles);
    printf("Angle in radians: %.2f\n", angleRadians);

    return 0;
}
