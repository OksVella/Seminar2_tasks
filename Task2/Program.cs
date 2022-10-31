int num = 67903;
if (num < 99)
{
    Console.Write("No third digit");
}
else
{
    if (num >= 1000)
    {
        int cutNumber = getCutNumber(num);
        printThirdDigit(cutNumber);
    }
    else
    {
        printThirdDigit(num);
    }
}


// --- Methods ---

void printThirdDigit(int num)
{
    int thirdDigit = num % 10;
    Console.Write(thirdDigit);
}

int getCutNumber(int num)
{
    int cutNumber = num;
    while (cutNumber >= 1000)
    {
        cutNumber = cutNumber / 10;
    }
    return cutNumber;
}
