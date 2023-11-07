#include <stdio.h>

//Function Declaration
void printWithComma (long num);

int main (void)
{
    //Local Declarations
    long number;

    //Statements
    printf("\nEnter a number with up to 6 digits: ");
    scanf ("%ld", &number);

    printWithComma (number);
    return 0;
}

void printWithComma (long num)
{
    //Local Declarations
    int thousands;
    int hundreds;
    //Statements
    thousands = num / 1000;
    hundreds = num % 1000;

    printf("\nThe number you entered is \t%03d, %03d", thousands, hundreds);
    return;
}