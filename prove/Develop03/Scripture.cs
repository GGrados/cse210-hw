using System;
class Scripture
{
    //attributes
    public string _reference;

    //default scripture
    private string _scriptureString = "And behold, all that he arequires of you is to keep his commandments; and he has promised you that if ye would keep his commandments ye should prosper in the land; and he never doth dvary from that which he hath said; therefore, if ye do ekeep his fcommandments he doth bless you and prosper you."; // default scripture

    private List<Word> _words = new List<Word>(); // List of words, each word an object 
    private List<Word> _wordsRemaining = new List<Word>();

    //Constructors
    public Scripture()
    {// In case any scriptures is provided 
        List<String> toList = _scriptureString.Split(' ').ToList(); // Converting string to list

        foreach (String currentWord in toList)
        {
            Word word = new Word(currentWord); // Creation of the word object
            _words.Add(word); // Adding the word object to the list

        }

    }
    public Scripture(string scripture) //  in case a string is provided
    {// In case a scriptures is provided 
        List<String> scripturetoList = scripture.Split(' ').ToList();

        foreach (String currentWord in scripturetoList)
        {
            Word word = new Word(currentWord);
            _words.Add(word);
        }
    }

    //Getters and Setters
    public void GetRenderedText()
    {
        Console.Write(_reference);
        foreach (Word word in _words)
        {

            Console.Write(word._text);
            Console.Write(" ");
        }
    }

    public void SetScripture(string scripture)
    {
        _scriptureString = scripture;
    }



    // Behaviors 
    public void HideWords(int quantityOfWordsToHide)
    {

        Random randomGenerator = new Random();

        for (int i = 0; i < quantityOfWordsToHide; i++)
        {
            int randomIndex = randomGenerator.Next(0, _words.Count());

            _words[randomIndex].Hide();


        }

    }


    public bool IsCompletelyHidden()
    {
        foreach (Word wordObject in _words)
        {
            if (wordObject._show == false)
            {
                continue;
            }
            if (wordObject._show == true)
            {
                return true;
            }
        }

        return false;
    }

}

