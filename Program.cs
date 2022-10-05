//#1
/* Console.Clear();
Console.WriteLine("Введите пятизначное число ниже: ");
string n = Console.ReadLine();
if (n[0]==n[4] & n[1]==n[3] & n.Length==5)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}*/
 
//#2
/* Console.Clear();
void WorkRepeatedly (int x,int y,int z, int x1, int y1, int z1)
{
    double result = Math.Sqrt((x1-x)^2+(y-y1)^2+(z-z1)^2);
    Console.Write(result);
}
string st = (Console.ReadLine());


void Method1(string s, int[] nums_of_s)
{
    for (int i=0; i <s.Length;i++)
    { 
        char ch = s[i];
        if (Char.IsNumber(ch))
        {
            int item = ch;
            Array.Resize(ref nums_of_s,nums_of_s.Length+1);
            nums_of_s[nums_of_s.Length-1]=item;
        }
    }
    
}
int[] nums_of_s = new int[0];
Method1(st,nums_of_s);
int x = nums_of_s[0];
int y = nums_of_s[1];
int z = nums_of_s[2];
int x1 = nums_of_s[3];
int y1 = nums_of_s[4];
int z1 = nums_of_s[5];
WorkRepeatedly(x,y,z,x1,y1,z1); */




//#3
/* Console.Clear();
void Cubs(int n)
{
    double[] ar=new double[0];
    for (int i=1; i<=n;i++)
    {
        double item = Math.Pow(i,3);
        Array.Resize(ref ar,ar.Length+1);
        ar[ar.Length-1]=item;
    }
    for (int i=0; i<ar.Length;i++)
    {
        if (i!=(ar.Length-1))
        {
            Console.Write(ar[i]+", ");
        }
        else
        {
            Console.Write(ar[i]);
        }
    }
    return;
}
Console.WriteLine("Введите число ниже");
int n = Convert.ToInt32(Console.ReadLine());

Cubs(n); */

