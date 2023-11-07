#include <stdio.h>

#define REG_FEE 10
#define UNIT_FEE 10
#define EXCESS_FEE 50

//Function Declarations
int calculateFee (int firsTerm, int secondTerm, int thirdTerm);
int termFee (int units);

int main(void)
{
     //Local Declarations
    int firsTerm;
    int secondTerm;
    int thirdTerm;
    int totalFee;

    //Statements
    printf("Enter units for first term: ");
    scanf ("%d", &firsTerm);

    printf("Enter units for second term: ");
    scanf ("%d", &secondTerm);

    printf("Enter units for first term: ");
    scanf ("%d", &thirdTerm);

    totalFee = calculateFee(firsTerm, secondTerm, thirdTerm);
    printf("\nThe totatl tuition is : %8d\n", totalFee);

    return 0;
}
int calculateFee (int firsTerm, int secondTerm, int thirdTerm)
{
     //Local Declarations
    int fee;
    fee = termFee(firsTerm) + termFee(secondTerm) + termFee(thirdTerm);
    return fee;
}

int termFee(int units)
{
    //Local Declarations
    int totalFees;
    //Statements
    totalFees = REG_FEE + ((units - 1) / 12 * EXCESS_FEE) + (units * UNIT_FEE);
    return (totalFees);
}