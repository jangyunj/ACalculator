Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter an operator: ");
char op = Convert.ToChar(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());


if (op == '+')
{
    Console.WriteLine(num1 + num2);
}
else if (op == '-')
{
    Console.WriteLine(num1 - num2);
}
else if (op == '*')
{
    Console.WriteLine(num1 * num2);
}
else if (op == '/')
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("invalid operator");
}