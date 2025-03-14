using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink
{
    public enum DrinkType
    {
        Drink1,
        Drink2,
        Drink3,
        Drink4,
        Drink5,
        Drink6,
    }

    public DrinkType drinkType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (drinkType)
        {
            default:
            case DrinkType.Drink1: return DrinkAssets.Instance.drink1Sprite;
            case DrinkType.Drink2: return DrinkAssets.Instance.drink2Sprite;
            case DrinkType.Drink3: return DrinkAssets.Instance.drink3Sprite;
            case DrinkType.Drink4: return DrinkAssets.Instance.drink4Sprite;
            case DrinkType.Drink5: return DrinkAssets.Instance.drink5Sprite;
            case DrinkType.Drink6: return DrinkAssets.Instance.drink6Sprite;
        }
    }
    
}

// TUTORIAL VIDEO I AM FOLLOWING: https://youtu.be/2WnAOV7nHW0
