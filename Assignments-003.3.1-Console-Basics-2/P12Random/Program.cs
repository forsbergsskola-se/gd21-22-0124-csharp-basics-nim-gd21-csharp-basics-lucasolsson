namespace Random
{
   class program
   {
      static void Main()
      {
         Console.WriteLine("Please pass me a seed (integer)");
         string seedstring = Console.ReadLine();
         int seed = int.Parse(seedstring);
         System.Random random = new System.Random(seed);

         
         Console.WriteLine("Three integers between 0 and 5");
         //Prints out 3 random integers between 0 and 5 so 0,1,2,3,4.
         Console.WriteLine(random.Next(0,5));
         Console.WriteLine(random.Next(0,5));
         Console.WriteLine(random.Next(0,5));
         
         Console.WriteLine("Three numbers between 0.0 and 0.5");
         //Prints out 3 random number between 0 and 0.5. 
         Console.WriteLine(random.NextDouble()*0.5);
         Console.WriteLine(random.NextDouble()*0.5);
         Console.WriteLine(random.NextDouble()*0.5);
         
         Console.WriteLine("Three numbers between 0.2 and 0.7");
         //Prints out 3 random numbers between 0.2 and 0.7. Remember to multiply the range with the 
         // difference between 0.7-0.2 = 0.5 and then add 0.2 to move all numbers up by 0.2. 
         Console.WriteLine(random.NextDouble()*(0.7-0.2)+0.2);
         Console.WriteLine(random.NextDouble()*(0.7-0.2)+0.2);
         Console.WriteLine(random.NextDouble()*(0.7-0.2)+0.2);
         
         Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
         string critstring = Console.ReadLine();
         double crit = double.Parse(critstring);
         
         Console.WriteLine(random.NextDouble() < crit ? "Crit" : "No Crit");
         Console.WriteLine(random.NextDouble() < crit ? "Crit" : "No Crit");
         Console.WriteLine(random.NextDouble() < crit ? "Crit" : "No Crit");
         Console.WriteLine(random.NextDouble() < crit ? "Crit" : "No Crit");
         Console.WriteLine(random.NextDouble() < crit ? "Crit" : "No Crit");
         
      }
   }
}

