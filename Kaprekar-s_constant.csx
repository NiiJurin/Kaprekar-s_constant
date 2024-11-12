int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int x = A[0];
if (A.Length ==2)
{
    int y = A[1];
    if (A.Length == 3)
    {
    int z = A[2];
    if (A.Length == 4)
        {
            int xa = A[3];
        }
    }
}



if (x.ToString().Length == 4 )
{
    int i = 0;
    int t = 0;
    while( i == 0 )
    {
        var (a1,a2,a3,a4) = Decomposition(x);
        var ResultS = GetS(a1, a2, a3, a4);
        var ResultL = GetL(a1, a2, a3, a4);
        var Result = Calculation(ResultL,ResultS);
        Console.WriteLine(Result);
        if(Result == t)
        {
            i = 1;
        }
        t = Result;
        x = Result;
    }

}

//4桁の分解
(int, int, int, int)Decomposition(int x)
{
    int a1 = int.Parse(x.ToString()[0].ToString());
    int a2 = int.Parse(x.ToString()[1].ToString());
    int a3 = int.Parse(x.ToString()[2].ToString());
    int a4 = int.Parse(x.ToString()[3].ToString());
    // int[] numbers = {a1,a2,a3,a4};
    return (a1,a2,a3,a4);
}

//4桁の数字
int GetS(int a, int b, int c, int d)
{  
    int[] NumberS = {a,b,c,d};
    Array.Sort(NumberS);
    string SmallNumber = string.Join("", NumberS);
    int ResultS = int.Parse(SmallNumber);
    return ResultS;
}
int GetL(int a, int b, int c, int d)
{  
    int[] NumberL = {a,b,c,d};
    Array.Sort(NumberL);
    Array.Reverse(NumberL);
    string LargeNumber = string.Join("", NumberL);
    int ResultL = int.Parse(LargeNumber);
    return ResultL;
}
int Calculation(int L,int S)
{
    int Result = L - S ;
    return Result;

}
// Console.WriteLine(A.Sum()); //加算
// Console.WriteLine(A.Aggregate(1,(x,y) => x*y)); //乗算
// Console.WriteLine(A.Aggregate((x,y) => x/y)); 



