class Program
{
    static void Main(string[] args)
    {
        Word word = new Word();
        Display display = new Display();
        int wrongGuesses = 0;
        char guess;
        bool runState = true;
        bool runState2 = true;
        display.displayWord(word);
        while (runState && runState2)
        {
            Console.Write("Guess a letter [a-z]: ");
            guess = Console.ReadLine()[0];
            Console.WriteLine();
            wrongGuesses += word.Comparison(guess);
            runState = display.displayWord(word);
            runState2 = display.DisplayMan(wrongGuesses);
            Console.WriteLine("^^^^^^^");
        }
        // runstate 1 tripped
        if(!runState)
        {
            Console.WriteLine("Congratulations, you win!");
        }
        // runstate 2 tripped
        if(!runState2)
        {
            Console.WriteLine("Sorry, you lose.");
        }
        Console.ReadKey();
    }
}