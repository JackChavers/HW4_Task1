// MIS 3013
// HW4 TASK 1
// Jack Chavers 113493948
//Q1

string outMesStr;
int N;




Console.Write("m=? ");
string mStr = Console.ReadLine();
double m = Convert.ToDouble(mStr);

Console.Write("x=? ");
string xStr = Console.ReadLine();
double x = Convert.ToDouble(xStr);

Console.Write("b=? ");
string bStr = Console.ReadLine();
double b = Convert.ToDouble(bStr);


double result = LineValueForY(m, x, b);
outMesStr = string.Format($"Y={m:F2}*{x:F2}+{b:F2}={result:F2}");
Console.WriteLine(outMesStr);



double LineValueForY(double m, double x, double b)
{
    double result = m * x + b;
    return result;
}

int Factorial(int N)
{
    int r = 1;
    for (int i = 1; i <= N; i++)
    {
        r = r * i;
    }
    return r;


}
Console.WriteLine();
Console.Write("n=? ");
string nStr = Console.ReadLine();
N = Convert.ToInt32(nStr);

int facR = Factorial(N);
outMesStr = string.Format($"{N}!=");
Console.Write(outMesStr);

for (int i = N; i >= 1; i--)
{
    Console.Write(i);
    if (i >= 2)
    {
        Console.Write('*');
    }

}

outMesStr = string.Format($"={facR}");
Console.WriteLine(outMesStr);

Console.ReadKey();