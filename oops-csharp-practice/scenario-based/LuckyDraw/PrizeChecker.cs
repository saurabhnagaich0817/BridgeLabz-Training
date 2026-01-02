using System;

class PrizeChecker
{
    public bool CheckWinner(int number)
    {
        // Number must be divisible by BOTH 3 and 5
        return number % 3 == 0 && number % 5 == 0;
    }
}
