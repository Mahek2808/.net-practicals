namespace calculator
{
    public class calculator
    {
        int num1;
        int num2;
        int result;

        public static void Main(string[] args)
        {

            calculator obj = new calculator();
            obj.num1 = 24;
            obj.num2 = 12;
            Console.WriteLine("Enter first number: " + obj.num1);
            Console.WriteLine("Enter second number: " + obj.num2);
            Console.ReadLine();
            obj.add();
            obj.subsract();
            obj.multiply();
            obj.divide();

        }
        void add()
        {
            result = num1 + num2;
            Console.WriteLine("The sum of 24 and 12 is " + result);
            Console.ReadLine();
        }

        void subsract()
        {
            result = num1 - num2;
            Console.WriteLine("The subtraction of 24 and 12 is " + result);
            Console.ReadLine();
        }

        void multiply()
        {
            result = num1 * num2;
            Console.WriteLine("The multiplication of 24 and 12 is " + result);
            Console.ReadLine();
        }

        void divide()
        {
            result = num1 / num2;
            Console.WriteLine("The division of 24 and 12 is " + result);
            Console.ReadLine();
        }
    }
}
