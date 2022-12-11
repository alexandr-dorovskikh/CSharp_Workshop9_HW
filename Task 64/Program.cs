void WriteNum(int Num)
{
    Console.Write(Num);

    if (Num > 1) Console.Write(", ");
    
    int NextNum = Num - 1;

    if (NextNum >= 1) WriteNum(NextNum);
        
}

Console.Write("Enter natural number:");
int FirstNum;
if (Int32.TryParse(Console.ReadLine(), out FirstNum)) 
{
    if (FirstNum <= 0) 
        Console.WriteLine("You entered not natural number");    
    else    
        WriteNum(FirstNum);
} 
else
    Console.WriteLine("You entered wrong value");



