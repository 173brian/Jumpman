class Display
{

    public bool DisplayMan(int wrongGuesses)
    {
        switch (wrongGuesses)
        {
            case (0):
                Console.WriteLine(" ___ ");
                goto case(1);
            case (1):
                Console.WriteLine("/___\\");
                goto case(2);
            case (2):
                Console.WriteLine("\\   /");
                goto case (3);
            case (3):
                Console.WriteLine(" \\ /");
                goto case (4);
            case (4):
                Console.WriteLine("  O");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\");
                Console.WriteLine();
                return true;
            case > 4:
                Console.WriteLine("  X");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\");
                Console.WriteLine();
                return false;
        }
        return false;
    }
    public bool displayWord(Word theWord)
    {
        bool gameState = true;
        int numOfTrue = 0;
        string displayString = "";
        for(int i = 0; i < theWord.displayWord.Length; i++)
        {

            if(theWord.displayWord[i])
                displayString += theWord.getWord[i] + " ";
            else
                displayString += "_ ";
        }
        foreach (bool b in theWord.displayWord)
            if (b)
                numOfTrue++;
        if (numOfTrue == (theWord.displayWord.Length))
            gameState = false;
        Console.WriteLine(displayString);
        Console.WriteLine();
        return gameState;
    }
}