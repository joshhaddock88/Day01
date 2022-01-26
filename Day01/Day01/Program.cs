using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miles();
            AllTheErrors();
        }

        private static void AllTheErrors()
        {
            int num = 13;
            int denom = 1;
            int result;
            int[] numbers = { 22, 33, 44 };

            try
            {
                result = num / denom;
                result = numbers[5];
                Console.WriteLine(result);
            }
            catch ( DivideByZeroException e )
            {
                Console.WriteLine("You divided by Zero!!!");
            }
            catch ( IndexOutOfRangeException e)
            {
                Console.WriteLine("The array isn't that big!");
            }
            finally
            {
                Console.WriteLine("You are done");
            }
        }

        public static void Miles()
        {
            try
            {
                int milesDriven, gallonsOfGas, mpg;

                Console.WriteLine("Enter the miles driven");
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many gallons of gas did you use?");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());
                mpg = milesDriven / gallonsOfGas;
                Console.WriteLine($"You drove {milesDriven} on {gallonsOfGas}. Which gives you an MPG of {mpg}");
            }
            catch ( Exception e )
            {
                Console.WriteLine("You have entered a bad value");
                Miles();
            }
        }
    }
}
