using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> brands;
    public WordSpawner wordSpawner;
    
    //used to check if user has started to type a word
    private bool activeWord;

    //controls currente active word that is being typed
    private Word activeBrand;

    //Boss health
    public int bossMaxHp = 1000;
    public int bossCurrentHp = 1000;

    //Score variables
    public int initialScore = 0;
    public int currentScore = 0;


    public void AddWord()
    {
        Word brand = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord(), this);
        Debug.Log(brand.word);

        brands.Add(brand);
    }

    public void TypeLetter(char letter)
    {
        if(activeWord)
        {
            if(activeBrand.GetNextLetter() == letter)
            {
                activeBrand.TypeLetter();
                bossCurrentHp -= 10;
                currentScore += 10;
                Debug.Log(currentScore);
            }
        }
        else
        {
            foreach(Word brand in brands)
            {
                if(brand.GetNextLetter() ==  letter)
                {
                    activeBrand = brand;
                    activeWord = true;
                    brand.TypeLetter();
                    break;
                }
            }
        }

        if(activeWord && activeBrand.WordTyped())
        {
            activeWord = false;
            RemoveWord(activeBrand);
        }

    }

    public void RemoveWord(Word word)
    {
        activeWord = false;
        brands.Remove(word);
    }

}