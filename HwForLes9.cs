//#1
/* void Numbers(int n)
{
    if (n>1)
    {
        Console.Write(n+", ");
        Numbers(n-1);
    }
    if (n==1) {Console.Write(n);}
}
Console.Clear();
Console.WriteLine("Введите число ниже:");
int n = Convert.ToInt32(Console.ReadLine());
Numbers(n); */

//#2
/* int SumBetween (int n, int m, int adder = 0)
{
    if ((n)>m)
    {
        int start = m+1;
        int end  = n-1;
        if (start==end)
        {
            adder = start;
        }
        else
        {
        adder = (start+end)*(end-start+1)/2;
        }
    }
    else {Console.WriteLine("Введите числа как указано в инструкции выше!");}
    return adder;
}

Console.Clear();
Console.WriteLine("Введите числа m и n ниже по одному через Enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов между числами - {SumBetween(n,m)}") ; */

//#3
/* int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    if (m>0 & n==0) return Akkerman(m-1,1);
    if (m>0 & n>0) return Akkerman(m-1,Akkerman(m,n-1)); 
    return Akkerman(m,n);
}
Console.Clear();
Console.WriteLine("Введите числа m и n ниже по одному через Enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m,n)); */
