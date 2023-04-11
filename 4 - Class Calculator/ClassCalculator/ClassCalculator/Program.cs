namespace Program {


class Calculator
{
    public int Sum(int a,int b)
    {
        return a + b;
    }
    public int Subs(int a, int b)
    {
        return a - b;
    }
    public int Mult(int a, int b)
    {
        return a * b;
    }
    public int Div(int a, int b)
    {
        return a / b;
    }
    public int Mod(int a, int b)
    {
        return a % b;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calculator calc = new Calculator();
                int num1, num2, result;
                char ch;
                Console.Write("Please enter a number : ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Please enter a process : ");
                ch = Console.ReadLine()[0];
                Console.WriteLine();
                Console.Write("Please enter a number : ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '+':
                        result = calc.Sum(num1, num2);
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;
                    case '-':
                        result = calc.Subs(num1, num2);
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    case '*':
                    case 'x':
                        result = calc.Mult(num1, num2);
                        Console.WriteLine(num1 + " x " + num2 + " = " + result);
                        break;
                    case '/':
                        result = calc.Div(num1, num2);
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    case '%':
                        result = calc.Mod(num1, num2);
                        Console.WriteLine(num1 + " % " + num2 + " = " + result);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid process!");
                        break;

                }
            }
        }
    }
}