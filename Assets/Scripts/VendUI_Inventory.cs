using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendUI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform drinkSlotContainer;
    private Transform drinkSlotTemplate;

    private void Awake()
    {
        drinkSlotContainer = transform.Find("drinkSlotContainer");
        drinkSlotTemplate = drinkSlotContainer.Find("drinkSlotTemplate");
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryDrinks();
    }

    private void RefreshInventoryDrinks()
    {
        int x = 0;
        int y = 0;
        float drinkSlotCellSize = 100f;
        foreach (Drink drink in inventory.GetDrinkList())
        {
            RectTransform drinkSlotRectTransform = Instantiate(drinkSlotTemplate, drinkSlotContainer).GetComponent<RectTransform>();
            drinkSlotRectTransform.gameObject.SetActive(true);
            drinkSlotRectTransform.anchoredPosition = new Vector2(x * drinkSlotCellSize, y * drinkSlotCellSize);
            x++;

            if (x > 4)
            {
                x = 0;
                y++;
            }
        }
    }
}
