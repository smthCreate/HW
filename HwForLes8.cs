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

void sortMass(int[,] nums)
{
    int[] aray = new int[nums.GetLength(1)];
    for (int i=0;i<nums.GetLength(0);i++)
    {
        for (int j=0;j<nums.GetLength(1);j++)
        {
            aray[j]=nums[i,j];
        }
        Array.Sort(aray);
        for (int j=0;j<nums.GetLength(1);j++)
        {
            nums[i,j]=aray[j];
        }
    }
}

Console.Clear();
int m =3;
int n=4;
int[,] matr = new int[m,n];
FillAr(matr);
PrintAr(matr);
Console.WriteLine();
sortMass(matr);
PrintAr(matr); */

//#2
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

int sortMass(int[,] nums)
{
    int sum = nums[1,1];
    int[] aray = new int[nums.GetLength(1)];
    for (int i=0;i<nums.GetLength(0);i++)
    {
        for (int j=0;j<nums.GetLength(1);j++)
        {
            aray[j]=nums[i,j];
        }
        if (aray.Sum()>sum)
        {
            sum=aray.Sum();
        }
        
    }
    return sum;
}

Console.Clear();
int m =3;
int n=4;
int[,] matr = new int[m,n];
FillAr(matr);
PrintAr(matr);
Console.WriteLine();
Console.WriteLine(sortMass(matr)); */

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

int[,] MassComp(int[,] nums1, int[,] nums2)
{
    int[,] result = new int[nums1.GetLength(0),nums1.GetLength(1)];
    for (int i =0; i<nums2.GetLength(0);i++)
    {
        for (int j=0; j<nums1.GetLength(1);j++)
        {
            result[i,j] = nums1[i,j]*nums2[i,j];
        }
       
    }
    return result;
}

Console.Clear();
int m =3;
int n=4;
int[,] matr = new int[m,n];
int[,] matr2 = new int[m,n];
FillAr(matr);
FillAr(matr2);
PrintAr(matr);
Console.WriteLine();
PrintAr(matr2);
Console.WriteLine();
int[,] result = MassComp(matr,matr2);
PrintAr(result); */

//#4
/* int[,,] FillAr(int[,,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            for (int c=0; c<nums.GetLength(2);c++)
            {
                nums[i,j,c]=new Random().Next(-10,10);
            }
        }
    }
    return nums;
}

void PrintAr(int[,,] nums)
{
    for (int i =0; i<nums.GetLength(0);i++)
    {
        for (int j=0; j<nums.GetLength(1);j++)
        {
            for (int c=0; c<nums.GetLength(2);c++)
            {
                Console.Write(nums[i,j,c]+$"({i},{j},{c})"+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] MassComp(int[,] nums1, int[,] nums2)
{
    int[,] result = new int[nums1.GetLength(0),nums1.GetLength(1)];
    for (int i =0; i<nums2.GetLength(0);i++)
    {
        for (int j=0; j<nums1.GetLength(1);j++)
        {
            result[i,j] = nums1[i,j]*nums2[i,j];
        }
       
    }
    return result;
}

Console.Clear();
int m =2;
int n=2;
int p =2;
int[,,] matr = new int[m,n,p];
FillAr(matr);
PrintAr(matr); */

//#5
/* string[,] FillAr(string[,] nums)
{   
    int[,] path = new int[,] {{0,0},{0,1},{0,2},
    {0,3},{1,3},{2,3},{3,3},{3,2},{3,2},{3,0},{2,0},{1,0},{1,1},{1,2},{2,2},{2,1}};
    int counter = 1;
    for (int i =0; i<path.GetLength(0);i++)
    {
        nums[path[i,0],path[i,1]] = counter.ToString();
        if (nums[path[i,0],path[i,1]].Length<2)
        {
            nums[path[i,0],path[i,1]] = "0"+nums[path[i,0],path[i,1]];
        }
        counter+=1;
    }
    return nums;
}

void PrintAr(string[,] nums)
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
int m =4;
int n=4;
string[,] matr = new string[m,n];
PrintAr(matr);
FillAr(matr);
PrintAr(matr);
Console.WriteLine(); */
