// Задание 1

System.Console.WriteLine("Task 1: ");
int a = new Random().Next(0,101);
System.Console.WriteLine("a = " + a);
int b = new Random().Next(0,101);
System.Console.WriteLine("b = " + b);
int max;

if (a > b)
{
    max = a;
    System.Console.WriteLine("Max = " + max);
    System.Console.WriteLine("Min = " + b);
}
else
{
    max = b;
    System.Console.WriteLine("Max = " + max);
    System.Console.WriteLine("Min = " + a);
}

// Задание 2
System.Console.WriteLine(" ");
System.Console.WriteLine("Task 2: ");
int c = new Random().Next(0,101);
System.Console.WriteLine("c = " + c);
if (max > c)
{
    System.Console.WriteLine("Maximum = " + max);
}
else 
{
    max = c;
    System.Console.WriteLine("Maximum = " + max);
}

// Задание 3 
System.Console.WriteLine(" ");
System.Console.WriteLine("Task 3: ");
System.Console.WriteLine("a = " + a);
if (a % 2 == 0)
{
    System.Console.WriteLine("Число a четное!");
}
else
{
    System.Console.WriteLine("Число a нечетное!");
    a = a-1;
}

// Задание 4
System.Console.WriteLine(" ");
System.Console.WriteLine("Task 4: ");
System.Console.WriteLine("a = " + a);

int temp = 2;

while (temp != a+2)
{
    Console.Write(temp + " ");
    temp += 2;
}