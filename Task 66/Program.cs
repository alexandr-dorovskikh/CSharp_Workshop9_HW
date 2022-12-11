int GetSequenceSum(int x, int Max)
{
    if (x > Max)
        return 0;
    else
        return x + GetSequenceSum(x + 1, Max);

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
int N = GetNaturalNumber("N", M);

Console.WriteLine($"Sum of sequence of nums {M} -> {N}: {GetSequenceSum(M, N)}");

