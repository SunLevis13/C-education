string s_N = Console.ReadLine();
int N = int.Parse(s_N);
int m = -N;

while (m <= N)
{
    Console.Write($"{m} ");
    m += 1;
}
