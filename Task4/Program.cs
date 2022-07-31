Random random = new Random();
int[,,] arr = new int[2, 2, 2];
for (int i = 0; i < arr.GetLength(0); i++)
{
 for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            arr[i, j, k] = random.Next(10, 99);
            int t = arr[i, j, k];
               int w = 0;
                if (w ==t)
                { 
                    break;
                }
                if (w != t)
                {
                t = w;
                }
        }
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
       {
        for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + " ");
                Console.Write("(");
                Console.Write(i);
                Console.Write(",");
                Console.Write(j);
                Console.Write(",");
                Console.Write(k);
                Console.Write(")");
            }
        Console.WriteLine();
       }
}
Console.ReadLine();