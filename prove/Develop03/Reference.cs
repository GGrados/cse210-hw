using System;

class Reference
{

    //attributes
    private string _book;
    private string _chapter;
    private string _verse;
    private string _secondVerse;


    // Constructors
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _secondVerse = secondVerse;

    }

    //Getter 
    public string GetReference()
    {

        if (string.IsNullOrEmpty(_secondVerse))
        {

            string reference = ($"{_book} {_chapter}:{_verse} ");
            return reference;
        }

        else
        {
            string reference = ($"{_book}: {_verse}-{_secondVerse} ");
            return reference;
        }

    }
}

