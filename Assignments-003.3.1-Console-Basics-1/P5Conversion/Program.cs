int number = 5;
float floatToInt;

string numberString = Convert.ToString(number);

Console.WriteLine(numberString);

numberString = "56.3";

floatToInt = Convert.ToSingle(numberString);

number = (int)Math.Round(floatToInt);

Console.WriteLine(number);