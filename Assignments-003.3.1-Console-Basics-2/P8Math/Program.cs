namespace P8Math
{
    class program
    {
        static void Main()
        {
            //first number
            Console.WriteLine("Give me your first number.");
            string firstString = Console.ReadLine();
            

            //second number
            Console.WriteLine("Give me your second number.");
            string secondString = Console.ReadLine();
            
          
            //converting
            double first = Convert.ToDouble(firstString);
            double second = Convert.ToDouble(secondString);

            Console.WriteLine("Max:");
            double max = System.Math.Max(first, second);
            Console.WriteLine(max);
            
            Console.WriteLine("Min:");
            double min = System.Math.Min(first, second);
            Console.WriteLine(min);

            Console.WriteLine("Sqrt:");
            double sqrt = System.Math.Sqrt(first);
            Console.WriteLine(sqrt);

            Console.WriteLine("Abs:");
            double abs = System.Math.Abs(first);
            Console.WriteLine(abs);
            
            Console.WriteLine("Floor:");
            double round = System.Math.Round(first);
            Console.WriteLine(round);
            
            Console.WriteLine("Floor:");
            double floor = System.Math.Floor(first);
            Console.WriteLine(floor);
            
            Console.WriteLine("Ceil:");
            double ceil = System.Math.Ceiling(first);
            Console.WriteLine(ceil);
            
            Console.WriteLine("Clamp:");
            double clamp = System.Math.Clamp(first, 0, second);
            Console.WriteLine(clamp);
            
            Console.WriteLine("Pow:");
            double pow = System.Math.Pow(first, second);
            Console.WriteLine(pow);
        }
    }
}

