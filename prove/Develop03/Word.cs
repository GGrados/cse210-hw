using System;

class Word
{

    //attributes
    public bool _show = true;
    public string _text;

    //Constructors
    public Word(string word)
    {
        _text = word;
    }


    public void Hide()
    {
        _text = "_ _ _";
        _show = false;
    }



}


