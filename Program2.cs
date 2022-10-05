/* 
//#1
Console.Clear();
Console.WriteLine("Введите 2 числа: ");
string srt = Console.ReadLine();
int[] a_and_b = new int[2];
int k = 0;
for (int i=0;i<srt.Length;i++)
{
        
    if (Char.IsNumber(srt[i]))
    {
        a_and_b[k]=(int)Char.GetNumericValue(srt[i]);
        k+=1;
    }
}

Console.WriteLine(Math.Pow(a_and_b[0],a_and_b[1])); */

//#2
/* void SumNum(int x)
{
    int s =0;
    while (x>=1)
    {
        s+=x%10;
        x/=10;
    }
    Console.WriteLine(s);
    return;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SumNum(number); */

//#3
/* Console.Clear();
Console.WriteLine("Введите элементы, которые хотите увидеть в массиве: ");
string srt = (Console.ReadLine());
int[] nums = new int[0];
string s ="";
for (int i=0;i<srt.Length;i++)
{

    if (Char.IsNumber(srt[i]) || srt[i]=='-')
    {
        if (i<(srt.Length-1))
        {
            s+=srt[i].ToString();
            if (Char.IsNumber(srt[i+1])==false)
            {
                Array.Resize(ref nums,nums.Length+1);
                nums[nums.Length-1]=Convert.ToInt32(s);
                s ="";  
            }
        }
        else 
        {
            s+=srt[i].ToString();
            Array.Resize(ref nums,nums.Length+1);
            nums[nums.Length-1]=Convert.ToInt32(s);
        }
        
    }
}
for (int i =0; i<nums.Length;i++)
{
    Console.Write(nums[i]+" ");
} */