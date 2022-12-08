int NumFirst;
int NumSec;
NumFirst = Convert.ToInt32(Console.ReadLine());
NumSec = Convert.ToInt32(Console.ReadLine());
if (NumFirst > NumSec)
{
    Console.WriteLine(NumFirst + " Первое число больше второго");
}
else {
    Console.WriteLine(NumSec + " Второе число больше второго");
}
