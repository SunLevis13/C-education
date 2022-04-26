string s_a = Console.ReadLine();
int a = int.Parse(s_a);
string s_b = Console.ReadLine();
int b = int.Parse(s_b);
string s_c = Console.ReadLine();
int c = int.Parse(s_c);

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.Write(max);