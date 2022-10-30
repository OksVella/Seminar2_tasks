int num = 852;
int secondDigit = getSecondDigit(num);
Console.Write(secondDigit);

// --- Methods ---

int getSecondDigit(int num)
{
    return num / 10 % 10;
}