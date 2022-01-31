int players = 2;
int matches = 24;
int minMatches = 1;
int maxMatches = 3;


Console.WriteLine("Welcome to Nim!");

while (!IsGameOver())
{
    PrintMatches();
    PlayerDraw();
    
    if (matches < 1)
    {
        Console.WriteLine("You lose");
    }
    else
    {
        PrintMatches();
        AIDraw();
        
        if (matches < 1)
        {
            Console.WriteLine("AI lose");
        }
    }
}

//Functions for the game
void PrintMatches()
{
    //Print matches  
    for (int i = 0; i < matches; i++)
    {
        Console.Write("|");
    }
    //New line for not getting everything on same line 
    Console.WriteLine($" {matches} ");
}

void PlayerDraw()                                                      
{                                                                      
    int inputNumber = 0;                                               
    while (inputNumber < minMatches || inputNumber > maxMatches)       
    {                                                                  
        Console.WriteLine("How many matches do you want to draw?");    
        string inputText = Console.ReadLine();                         
        inputNumber = int.Parse(inputText);                            
    }                                                                  
    matches -= inputNumber;                                            
}                                                                      

void AIDraw()
{
    int inputNumber = 3;
    Console.WriteLine($"The AI draws {inputNumber} matches");
    matches -= inputNumber;
}

bool IsGameOver()
{
    return matches < 1;
}









