Console.WriteLine("Введите натуральное число больше 1: ");
int n = Convert.ToInt16(Console.ReadLine());

void NumberCounter(int n)
{
    if (n < 0) Console.Write($"{n} не натуральное число");
    if (n == 0) return;
    Console.Write("{0,4}",n);
    NumberCounter (n-1);
}
NumberCounter(n);