string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int m = 1;

while (m <= N)
{
    if(m % 2 == 0)
    Console.Write($"{m} ");
    m += 1;
}
