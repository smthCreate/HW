//#1
/* void FillAr(int[] mass)
{
    for (int i=0;i<mass.Length;i++)
    {
        mass[i]=new Random().Next(100,1000);
    }
}

int CheckUp(int[] mass)
{
    int k =0;
    for (int i=0;i<mass.Length;i++)
    {
        if (mass[i]%2==0)
        {
            k+=1;
        }
    }
    return k;
}
Console.Clear();
Console.WriteLine("Введите сколько элементов вы хотите видеть в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillAr(numbers);
for (int i=0;i<numbers.Length;i++)
{
    Console.Write(numbers[i]+" ");
}
Console.WriteLine();
Console.WriteLine(CheckUp(numbers)); */

//#2
/* void FillAr(int[] mass)
{
    for (int i=0;i<mass.Length;i++)
    {
        mass[i]=new Random().Next(-1000,1000);
    }
}

int CheckUp(int[] mass)
{
    int counter =0;
    for (int i=0; i<mass.Length;i++)
    {
        if (i%2!=0)
        {
            counter+=mass[i];
        }
    }
    return counter;
}

Console.Clear();
Console.WriteLine("Введите сколько элементов вы хотите видеть в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillAr(numbers);
for (int i=0;i<numbers.Length;i++)
{
    Console.Write(numbers[i]+" ");
}
Console.WriteLine();
Console.WriteLine(CheckUp(numbers)); */

//#3
/* void FillAr(int[] mass)
{
    for (int i=0;i<mass.Length;i++)
    {
        mass[i]=new Random().Next(-1000,1000);
    }
}

int Difference(int[] mass)
{
    int max =mass[0];
    int min = mass[0];
    for (int i=0; i<mass.Length;i++)
    {
        if (mass[i]>max)
        {
            max = mass[i];
        }
        if (mass[i]<min)
        {
            min = mass[i];
        }
    }
    int dif = max - min;
    return dif;
}

Console.Clear();
Console.WriteLine("Введите сколько элементов вы хотите видеть в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillAr(numbers);
for (int i=0;i<numbers.Length;i++)
{
    Console.Write(numbers[i]+" ");
}
Console.WriteLine();
Console.WriteLine(Difference(numbers)); */