int m = 0;
int n = 0;
int v = 0;
int p = 1;
int z = 0;
int g = 0;
int [,] matrix = new int [2,2];
Random rand = new Random();
for (int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++) 
    {
    matrix[i,j] = rand.Next(0, 10);
    Console.Write(" ");
    Console.Write(matrix[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
int [,] matrix2 = new int [2,2];
Random random = new Random();
for (int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++) 
    {
    matrix2[i,j] = random.Next(0, 10);
    Console.Write(" ");
    Console.Write(matrix2[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine(" ");
void matrixProduct(int a, int b, int c, int d, int e, int f)
{
    int sum1 = 0;
    while(b < 2)
    {
        int num1 = matrix[a,b] * matrix2[b, a];
        sum1 = sum1 + num1;
        ++b;
    }
    Console.Write(sum1);
    int sum2 = 0;
    while(c < 2)
    {
        int num2 = matrix[a,c] * matrix2[c, d];
        sum2 = sum2 + num2;
        ++c;
    }
    Console.Write(" ");
    Console.Write(sum2);
    Console.WriteLine(" ");
    int sum3 = 0;
    while (v < 2)
    {
        int num3 = matrix[d,v] * matrix2[v,a];
        sum3 = sum3 + num3;
        ++v;
    }
    Console.Write(sum3);
    int sum4 = 0;
    while (f < 2)
    {
        int num4 = matrix[d,f] * matrix2[f,d];
        sum4 = sum4 + num4;
        ++f;
    }
    Console.Write(" ");
    Console.Write(sum4);
}
matrixProduct(m, n, v, p, z, g);