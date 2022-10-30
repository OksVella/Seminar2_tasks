int num = 852;
int secondDigit = get2Digit(num);
Console.Write(secondDigit);

// --- Methods ---

int get2Digit(int num)
{
    return num / 10 % 10;
}