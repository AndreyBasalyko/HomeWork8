int m = 4;
int n = 4;
 int s = 1;
 int[,] array = new int[m, n];
 for (int i = 0; i < n; i++) 
 {
    array[0, i] = s;
    s++;
}
for (int j = 1; j < m; j++) 
{
    array[j , n - 1] = s;
    s++;
}
for (int i = n - 2; i >= 0; i--) 
{
    array[m - 1, i] = s;
    s++;
}
for (int j = m - 2; j > 0; j--) 
{
    array[j, 0] = s;
    s++;
}
int c = 1;
int d = 1;
 while (s < m * n) 
 {
    while (array[c, d + 1] == 0) 
    {
        array[c, d] = s;
        s++;
        d++;
    }
    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }
    while (array[c, d - 1] == 0) 
    {
        array[c, d] = s;
        s++;
        d--;
    }
    while (array[c - 1, d] == 0) 
    {
        array[c, d] = s;
        s++;
        c--;
    }
}
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x, y] == 0) 
        {
            array[x, y] = s;
        }
    }
}
for (int x = 0; x < m; x++) 
{
    for (int y = 0; y < n; y++) 
    {
        if (array[x, y] < 10)
        {
            Console.Write(array[x,y]);
            Console.Write(", ");
        } 
        else 
        {
            Console.Write(array[x, y]);
            Console.Write(",");
        }
    }
    Console.WriteLine();
}