#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int numPoints;
    FILE *filePointer;

    // Open file in write mode
    filePointer = fopen("points.txt", "w");

    // Check if the file opened successfully
    if (filePointer == NULL) {
        printf("Error opening the file.\n");
        return 1;
    }

    // Seed for random number generation
    srand(time(0));

    // Ask user for the number of points
    printf("Enter the number of points: ");
    scanf("%d", &numPoints);

    // Generate random coordinates and write to the file
    for (int i = 0; i < numPoints; i++) {
        // Generate random x and y coordinates within the specified range
        double x = (rand() % 21) - 10; // Random number between -10 and 10
        double y = ((rand() % 11) - 5) * 1.0; // Random number between -5 and 5

        // Write coordinates to the file
        fprintf(filePointer, "%.2lf, %.2lf\n", x, y);
    }

    // Close the file
    fclose(filePointer);
    printf("Coordinates have been written to points.txt\n");

    return 0;
}
