using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Drink> drinkList;

    public Inventory()
    {
        drinkList = new List<Drink>();
        AddDrink(new Drink { drinkType = Drink.DrinkType.Drink1, amount = 1 });
        AddDrink(new Drink { drinkType = Drink.DrinkType.Drink2, amount = 1 });
        AddDrink(new Drink { drinkType = Drink.DrinkType.Drink3, amount = 1 });
        AddDrink(new Drink { drinkType = Drink.DrinkType.Drink4, amount = 1 });
    }

    public void AddDrink(Drink drink)
    {
        drinkList.Add(drink);
    }

    public List<Drink> GetDrinkList()
    {
        return drinkList;
    }

}
