//ints for game
int players = 2;
int matches = 24;
int minMatches = 1;
int maxMatches = 3;


Console.WriteLine("Welcome to Nim!");

//Core loop
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

//--------------------------------------------------
//Functions for the game


//print matches how many matches is left after player and ai has drawn
void PrintMatches()
{
    //Print matches  
    for (int i = 0; i < matches; i++)
    {
        Console.Write("|");
    }
    Console.WriteLine($" {matches} ");
}

//Player function
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

//AI function
void AIDraw()
{
    int inputNumber = 3;
    Console.WriteLine($"The AI draws {inputNumber} matches");
    matches -= inputNumber;
}

//Check if game is over or not
bool IsGameOver()
{
    return matches < 1;
}









