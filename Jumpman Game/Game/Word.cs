class Word
{
    private string word;
    public bool[] displayWord;
    private List<string> words;
    Random r;
    public string getWord
    { 
        get {return word;}
    }

    public Word()
    {
        r = new Random();
        words = new List<string>();
        words.Add("cool");
        word = words[(r.Next(0, words.Count))];
        displayWord = new bool[word.Length];
    }

    // returns 1 for wrong guess, while a 0 value indicates the character was present.
    public int Comparison(char c)
    {
        if (!word.Contains(c))
            return 1;
        int doubleEntryCheck = word.IndexOf(c);
        if (displayWord[doubleEntryCheck--])
            return 1;
        for(int i = 0; i < word.Length; i++)
        {
            if (word[i] == c)
            {
                displayWord[i] = true;
            }
        }
        return 0;
    }
}