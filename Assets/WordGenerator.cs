using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] FalseBrand = {"nike", "coca-cola", "apple", "microsoft", "bmw", 
                                            "gucci", "chanel", "mcdonald's", "visa", "samsung", 
                                            "amazon", "sony", "google", "adidas", "puma", 
                                            "ford", "chevrolet", "levi's", "tiffany y co.", 
                                            "rolex", "pepsi", "heineken", "nestle", "kellogg's",
                                             "intel", "canon", "nikon", "hp", "dell", "ibm", 
                                             "porsche", "ferrari", "lamborghini", 
                                             "rolls-royce", "guerlain", "l'oreal", "sephora", 
                                             "under armour", "toyota", "mercedes-benz", "audi", 
                                             "louis vuitton", "hermes", "omega", "cartier", 
                                             "montblanc"};

    public static string GetRandomWord()
    {
        int index = Random.Range(0, FalseBrand.Length);
        string randomBrand = FalseBrand[index];

        return randomBrand;
    }
    
}
