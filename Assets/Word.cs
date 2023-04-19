using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int index;

    WordDisplay display;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        index = 0;
        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[index];
    }

    public void TypeLetter()
    {
        index++;
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (index >= word.Length);
        if(wordTyped)
        {
            display.RemoveWord();
        }
        return wordTyped;
    }


}
