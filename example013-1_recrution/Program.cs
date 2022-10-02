// рекурсию можно использовать в самых разных методах
Double Factorial (double n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
double n = 20;
for (int i = 1; i <= n; i++)
{ 
    Console.WriteLine($"факториал {i} = {Factorial(i)}");
}

int Fibonacci(int num)
{
    if (num == 1 || num == 2) return 1;
    else return Fibonacci(num -1) + Fibonacci(num - 2);
}
int number = 40;
for (int i = 1; i <= n; i++)
{ 
    Console.WriteLine(Fibonacci(i));
}