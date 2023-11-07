#include <stdio.h>
#include <math.h>

// Function to calculate Euclidean distance between two points
double calculateDistance(double x1, double y1, double x2, double y2) {
    return sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
}

int main() {
    FILE *inputFile, *outputFile;
    double x1, y1, x2, y2;
    
    // Open input file in read mode
    inputFile = fopen("points.txt", "r");

    // Check if the input file opened successfully
    if (inputFile == NULL) {
        printf("Error opening the input file.\n");
        return 1;
    }

    // Open output file in write mode
    outputFile = fopen("distance.txt", "w");

    // Check if the output file opened successfully
    if (outputFile == NULL) {
        printf("Error opening the output file.\n");
        fclose(inputFile);
        return 1;
    }

    // Read coordinates from input file and calculate distances
    while (fscanf(inputFile, "%lf, %lf", &x1, &y1) == 2) {
        while (fscanf(inputFile, "%lf, %lf", &x2, &y2) == 2) {
            // Calculate Euclidean distance between points (x1, y1) and (x2, y2)
            double distance = calculateDistance(x1, y1, x2, y2);
            
            // Write the distance to the output file
            fprintf(outputFile, "Distance between (%.2lf, %.2lf) and (%.2lf, %.2lf): %.2lf\n", x1, y1, x2, y2, distance);
        }
        // Move the file pointer back to the beginning of the file
        fseek(inputFile, 0, SEEK_SET);
    }

    // Close the input and output files
    fclose(inputFile);
    fclose(outputFile);

    printf("Distances have been calculated and written to distance.txt.\n");

    return 0;
}
