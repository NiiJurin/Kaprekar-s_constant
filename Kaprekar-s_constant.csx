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

    int previousResult = -1;
    int currentResult = x;

    while (currentResult != previousResult)
    {
        previousResult = currentResult;
        var (a1, a2, a3, a4) = Decompose(currentResult);
        int resultS = GetS(a1, a2, a3, a4);
        int resultL = GetL(a1, a2, a3, a4);
        currentResult = resultL - resultS;
        Console.WriteLine(currentResult);
    }

}

//4桁の分解
(int, int, int, int)Decompose(int x)
{
    int a1 = int.Parse(x.ToString()[0].ToString());
    int a2 = int.Parse(x.ToString()[1].ToString());
    int a3 = int.Parse(x.ToString()[2].ToString());
    int a4 = int.Parse(x.ToString()[3].ToString());
    return (a1,a2,a3,a4);
}

//4桁の数字
int GetS(int a, int b, int c, int d)
{  
    int[] NumberS = {a,b,c,d};
    Array.Sort(NumberS);
    string SmallNumber = string.Join("", NumberS);
    return int.Parse(SmallNumber);
    
}
int GetL(int a, int b, int c, int d)
{  
    int[] NumberL = {a,b,c,d};
    Array.Sort(NumberL);
    Array.Reverse(NumberL);
    string LargeNumber = string.Join("", NumberL);
    return int.Parse(LargeNumber);
}
int Calculation(int L,int S)
{
    int Result = L - S ;
    return Result;

}
// Console.WriteLine(A.Sum()); //加算
// Console.WriteLine(A.Aggregate(1,(x,y) => x*y)); //乗算
// Console.WriteLine(A.Aggregate((x,y) => x/y)); 



