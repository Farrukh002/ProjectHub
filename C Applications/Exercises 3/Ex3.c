#include <stdio.h>

int main() {
    int price, coins200, coins100, coins50, coins10, coins5;

    // Input the price of the product
    printf("Enter the price of the product in forints: ");
    scanf("%d", &price);

    // Calculate the number of coins for each denomination
    coins200 = price / 200;
    price %= 200;

    coins100 = price / 100;
    price %= 100;

    coins50 = price / 50;
    price %= 50;

    coins10 = price / 10;
    price %= 10;

    coins5 = price / 5;

    // Print the results
    printf("Number of 200 forints coins: %d\n", coins200);
    printf("Number of 100 forints coins: %d\n", coins100);
    printf("Number of 50 forints coins: %d\n", coins50);
    printf("Number of 10 forints coins: %d\n", coins10);
    printf("Number of 5 forints coins: %d\n", coins5);

    return 0;
}
