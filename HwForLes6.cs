//#1
/* 
int[] CreatingMass(string srt)
{
    string s ="";
    int[] nums = new int[0];
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
    return nums;
}

int Counter(int[] nums)
{
    int k_unter=0;
    for (int i=0;i<nums.Length;i++)
    {
        if (nums[i]>0)
        {
            k_unter+=1;
        }
    }
    return k_unter;
}

Console.Clear();
Console.WriteLine("Введите элементы, которые хотите увидеть в массиве: ");
string srt = (Console.ReadLine());
Console.WriteLine("Чисел больших 0: "+Counter(CreatingMass(srt))); */

//#2
/* int[] CreatingMass(string srt)
{
    string s="";
    int[] nums = new int[0];
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
    return nums;
}
void Calc(int[] mass, float x, float y)
{
    x = (float)(mass[5]-mass[1])/(mass[3]-mass[7]);
    y = (float)mass[3]*x+mass[1];
    Console.Write($"({x};{y})");
}

Console.Clear();
Console.WriteLine("Введите значения b1, k1, b2 и k2 в одну строку ниже: ");
string lines = Console.ReadLine();
float x =0;
float y = 0;

int[] r_nums = CreatingMass(lines);
for (int i=0;i<r_nums.Length;i++)
{
    Console.Write(" "+r_nums[i]);
}
Console.WriteLine();
Calc(CreatingMass(lines),x,y); */



