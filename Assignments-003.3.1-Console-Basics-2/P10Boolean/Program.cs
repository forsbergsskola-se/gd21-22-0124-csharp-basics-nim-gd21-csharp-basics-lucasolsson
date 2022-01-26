bool isChild = false;
bool isTeenager = false;
bool isGrownup = false;

Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

if (age >= 0 && age <= 12)
{
    isChild = true;
}

if (age >= 13 && age <= 19)
{
    isTeenager = true;
}

if (age > 12)
{
    isGrownup = true;
}

Console.WriteLine("You are a child:" + isChild);
Console.WriteLine("You are a teenager:" + isTeenager);
Console.WriteLine("You are a grown-up:" + isGrownup);