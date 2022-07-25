int [,] array = new int [4, 4];
Random random = new Random ();
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
for (int i = 0; i < 4; i++)
{ 
    for (int j = 0; j < 4; j++)
    { 
        array[i,j] = random.Next(-100, 100) ;
        Console.Write(array[i,j]);
        Console.Write("; ");
    }   
    Console.WriteLine();
}
void findSum(int m, int n, int x, int y, int t)
{
    int sum = 0;
    while (n < 4)
    {
        sum = sum + array[m,n];
        ++n;
    }
    ++m;
    int sum2 = 0;
    while (x < 4)
    {
        sum2 = sum2 + array[m,x];
        ++x;
    }
    ++m;
    int sum3 = 0;
    while (y < 4)
    {
        sum3 = sum3 + array[m,y];
        ++y;
    }
    ++m;
    int sum4 = 0;
    while (t < 4)
    {
        sum4 = sum4 + array[m,t];
        ++t;
    }
    if (sum < sum2)
    {
       if (sum < sum3)
       {
        if (sum < sum4)
        {
             Console.WriteLine("1 строка");
        }
        else
        {
             Console.WriteLine("4 строка");
        }
       }
       else
       {
        if (sum3 < sum4)
        {
             Console.WriteLine("3 строка");
        }
        else
        {
             Console.WriteLine("4 строка");
        }
       }
    }
    else
    {
        if (sum2 < sum3)
        {
            if (sum2 < sum4)
            {
                 Console.WriteLine("2 строка");
            }
            else
            {
                 Console.WriteLine("4 строка");
            }
        }
        else
        {
            if (sum3 < sum4)
            {
                 Console.WriteLine("3 строка");
            }
            else
            {
                 Console.WriteLine("4 строка");
            }
        }
    }
}
findSum(a, b, c, d, e);