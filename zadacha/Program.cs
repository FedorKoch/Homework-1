Console.Clear();
Console.WriteLine("введите a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("введите c");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
                max = b;
if  (c > max)  
                max = c;

 Console.WriteLine(max);
