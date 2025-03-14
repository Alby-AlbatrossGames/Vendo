using JetBrains.Annotations;
using UnityEngine;

public class DrinkAssets : MonoBehaviour
{
    public static DrinkAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite drink1Sprite;
    public Sprite drink2Sprite;
    public Sprite drink3Sprite;
    public Sprite drink4Sprite;
    public Sprite drink5Sprite;
    public Sprite drink6Sprite;
}
