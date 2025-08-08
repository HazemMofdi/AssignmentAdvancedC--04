namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue1 = false;
            bool isTrue2 = false;
            bool isTrue3 = false;
            int num1 = 0;
            int num2 = 0;
            char op = 'a';

            while (!isTrue1)
            {
                Console.Write("Enter The First Number: ");
                if(int.TryParse(Console.ReadLine(), out num1))
                {
                    isTrue1 = true;
                    while(!isTrue2)
                    {
                        Console.Write("Enter The Operator [+, -, *, /]: ");
                        char[] ops = ['+', '-', '*', '/'];
                        if (char.TryParse(Console.ReadLine(), out op) && ops.Contains(op))
                        {
                            isTrue2 = true;
                            while (!isTrue3)
                            {
                                Console.Write("Enter The Second Number: ");
                                if (int.TryParse(Console.ReadLine(), out num2))
                                {
                                    if (op == '/' && num2 == 0)
                                    {
                                        Console.WriteLine("Second number cannot be zero for division. Try again.");
                                        continue;
                                    }
                                    isTrue3 = true;
                                }
                            }
                        }
                    }
                }
            }

            MathDelegate mathDelegate = op switch
            {
                '+' => MathFunctions.Sum,
                '-' => MathFunctions.Subtract,
                '*' => MathFunctions.Multiplication,
                '/' => MathFunctions.Sum
            };


            Console.WriteLine($"Result = {mathDelegate(num1, num2)}");

        }
    }
}
