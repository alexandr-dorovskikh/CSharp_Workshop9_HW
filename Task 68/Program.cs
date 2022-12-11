int AckermannFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunc(m - 1, 1);
    else
        return AckermannFunc(m - 1, AckermannFunc(m, n -1));
}

int GetNaturalNumber(string VarName, int MinValue = 0)
{
    int Num;

    Console.Write($"{VarName} = ");

    if (Int32.TryParse(Console.ReadLine(), out Num))
    {
        if (Num <= 0)
        {
            Console.WriteLine("You entered not natural number");
            return GetNaturalNumber(VarName);
        }
        else if (Num < MinValue)
        {
            Console.WriteLine($"Number must be more than {MinValue}");
            return GetNaturalNumber(VarName);
        }
        else
            return Num;
    }
    else
    {
        Console.WriteLine("You entered wrong value");
        return GetNaturalNumber(VarName);
    }
}

int M = GetNaturalNumber("M");
int N = GetNaturalNumber("N");

Console.WriteLine($"A(m,n) = {AckermannFunc(M, N)}");