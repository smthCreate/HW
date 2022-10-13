//#1
/* int[,] FillAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            nums[i,j]=new Random().Next(-10,10);
        }
    }
    return nums;
}

void PrintAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            Console.Write(nums[i,j]+" ");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("Введите размерность матрицы двумя числами по отдельности ниже: ");
int m =Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m,n];
FillAr(matr);
PrintAr(matr); */

//#2
/* int[,] FillAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            nums[i,j]=new Random().Next(1,10);
        }
    }
    return nums;
}

void PrintAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            Console.Write(nums[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int changeMass(int[,] nums,int x, int y)
{
    x-=1;
    y-=1;
    int result = 0;
    if (x>-1 & x<nums.GetLength(0) & y>-1 & y<nums.GetLength(1))
    {
        result = nums[x,y];
    }
    else
    {
        result = -100;
    }
    return result;
}
Console.Clear();
Console.WriteLine("Введите размерность матрицы двумя числами по отдельности ниже: ");
int m =Convert.ToInt32(Console.ReadLine());
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента двумя числами по отдельности ниже: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m,n];
FillAr(matr);
Console.WriteLine();
Console.WriteLine("Massive:");
PrintAr(matr);
Console.WriteLine();
int res = changeMass(matr,x,y);
if (res ==-100)
{
    Console.WriteLine("There is not such position");
}
else
{
    Console.WriteLine($"There is a number o this position - {res}");
} */

//#3
/* int[,] FillAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            nums[i,j]=new Random().Next(-10,10);
        }
    }
    return nums;
}

void PrintAr(int[,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            Console.Write(nums[i,j]+" ");
        }
        Console.WriteLine();
    }
}

double[] changeMass(int[,] nums,int rows,int cols)
{
    double[] results = new double[cols];
    for (int i =0; i<nums.GetLength(1);i++)
    {   
        double averege = 0;
        for (int j=0; j<nums.GetLength(0);j++)
        {
            averege+=nums[j,i];
        }
        averege = averege/rows;
        results[i] = averege;
    }
    return results;
}

Console.Clear();
int m =3;
int n=4;
int[,] matr = new int[m,n];
FillAr(matr);
PrintAr(matr);
Console.WriteLine();
double[] results= changeMass(matr,m,n);
for (int i=0;i<results.Length;i++)
{
    Console.Write(" "+$"[{results[i]}]");
} */