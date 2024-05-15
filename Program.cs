namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator! Write your first number to begin?");
            string number1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"1. {number1} + ?");
            Console.WriteLine($"2. {number1} - ?");
            Console.WriteLine($"3. {number1} * ?");
            Console.WriteLine($"4. {number1} / ?");
            string userInput = Console.ReadLine();
            char symbol = '_';
            switch (userInput)
            {
                case "1":
                    symbol = '+';
                    break;
                case "2":
                    symbol = '-';
                    break;
                case "3":
                    symbol = '*';
                    break;
                case "4":
                    symbol = '/';
                    break;
            }
            Console.Clear();
            Console.WriteLine("Please enter the second number");
            Console.WriteLine($"{number1} {symbol} ?");
            string number2 = Console.ReadLine();

            int answer = 0;
            switch (symbol)
            {
                case '+':
                    answer = Calculate.Add(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    break;
                case '-':
                    answer = Calculate.Subtract(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    break;
                case '*':
                    answer = Calculate.Multiply(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    break;
                case '/':
                    answer = Calculate.Divide(Convert.ToInt32(number1), Convert.ToInt32(number2));
                    break;
            }
            

            Console.WriteLine($"{number1} {symbol} {number2} = {answer}");


        }
    }
}
