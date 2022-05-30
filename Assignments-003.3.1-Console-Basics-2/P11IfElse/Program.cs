namespace P11IfElse
{
    class program
    {
        static void Main()
        {
            string grownup = "You are a grown-up";

            Console.WriteLine("What's your age?");
            string ageinput = Console.ReadLine();
            int age = Convert.ToInt32(ageinput);

            if (age >= 18)
            {
                Console.WriteLine(grownup);
            }

            Console.WriteLine("Give me another integer");
            string secondint = Console.ReadLine();
            int number = Convert.ToInt32(secondint);

            int max = System.Math.Max(age, number);
            
            Console.WriteLine("The maximum is: " + max);

            if (age % 2 == 1)
            {
                Console.WriteLine("Your number is an odd number.");
            }
        }
    }
}

