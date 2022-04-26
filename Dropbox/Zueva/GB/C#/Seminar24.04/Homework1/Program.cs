string s_a = Console.ReadLine();
int a = int.Parse(s_a);
if(a < 0)

{
    Console.Write($"{-a} ");
    a += 1;
}
else
if(a>=0)

{
    Console.Write($"{a} ");
    a += 1;
}