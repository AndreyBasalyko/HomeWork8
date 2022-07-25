int [,] array = new int [3, 4];
Random random = new Random ();
int a = 0;
int b = 0;
int c = 0;
int r = 0;
int d = 0;
for (int i = 0; i < 3; i++)
{ 
    for (int j = 0; j < 4; j++)
    { 
        array[i,j] = random.Next(-100, 100) ;
        Console.Write(array[i,j]);
        Console.Write("; ");
    }   
    Console.WriteLine();
}
void method(int m, int n, int x, int y, int t)
{
    int max = array[m,n];
    while (n < 4)
    {
       if(max > array[m,n])
      {
        ++n;
      }
      else
      {
        max = array[m,n];
        ++n;
      }
    }
    int max2 = array[m,x];
    while (x < 4)
    {
        if (max == max2)
        {
            ++x;
            max2 = array[m,x];
        }
        else
        {
            if (max2 < array[m,x])
            {
                if (max > array[m,x])
                {
                    max2 = array[m,x];
                }
                else
                {
                    ++x;
                }
            }
            else
            {
                ++x;
            }
        }
    }
    int max3 = array[m,y];
    while (y < 4)
    {
        if (max == max3)
        {
            ++y;
            max3 = array[m,y];
        }
        else
        {
            if (max2 == max3)
            {
                y++;
                max3 = array[m,y];
            }
            else
            {
                if (max3 < array[m,y])
                {
                    if (max2 > array[m,y])
                    {
                        max3 = array[m,y];
                    }
                    else
                    {
                        ++y;
                    }
                }
                else
                {
                    ++y;
                }
            }
        }
    }
    int max4 = array[m,t];
    while (t < 4)
    {
        if (max == max4)
        {
            ++t;
            max4 = array[m,t];
        }
        else
        {
            if (max2 == max4)
            {
                ++t;
                max4 = array[m,t];
            }
            else
            {
                if (max3 == max4)
                {
                    ++t;
                    max4 = array[m,t];
                }
                else
                {
                    if (max4 < array[m,t])
                    {
                        if (max3 > array[m,t])
                        {
                            max4 = array[m,t];
                        }
                        else
                        {
                            ++t;
                        }
                    }
                    else
                    {
                        ++t;
                    }
                }
            }
        }
    }
    Console.Write(max);
    Console.Write("; ");
    Console.Write(max2);
    Console.Write("; ");
    Console.Write(max3);
    Console.Write("; ");
    Console.Write(max4);
    Console.Write("; ");
}
while (a < 3)
{
    Console.WriteLine("");
    method(a,b,c,r,d);
    ++a;
}